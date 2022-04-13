using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ShoppingAppData.Models;
using ShoppingApp.Controlers;
using ShoppingApp.UserControls.ItemPreviews;

namespace ShoppingApp.UserControls
{
    public partial class CartPage : CustomPage
    {
        public CartPage(User user)
        {
            InitializeComponent();

            //Settings for initializing the Page
            TabPage tabPage = new TabPage("Cart");
            tabPage.Controls.Add(this);
            FormApp.TabControl.Controls.Add(tabPage);
            FormApp.TabControl.SelectedTab = tabPage;

            MainControl = flowLayoutPanel1;

            PopulateWithItems(user);
            CartPage_Resize(this, new EventArgs());

            //Subscribes every CartItem in the list with the appropriate event
            for (int i = 0; i < MainControl.Controls.Count; i++)
            {
                ((CartItem)(MainControl.Controls[i])).buttonRemove.Click += new System.EventHandler(this.UpdateOrderInfo);
                ((CartItem)(MainControl.Controls[i])).checkBoxSelected.CheckedChanged += new System.EventHandler(this.UpdateOrderInfo);
                ((CartItem)(MainControl.Controls[i])).comboBoxQuantity.TextChanged += new System.EventHandler(this.UpdateOrderInfo);
            }
            UpdateOrderInfo(this, new EventArgs());
        }


        //Event used to handle resizing of the Form
        private void CartPage_Resize(object sender, EventArgs e)
        {
            if (MainControl == null) return;

            panelOrderInfo.Width = (int)(Width / 5 * 2);

            for (int i = 0; i < MainControl.Controls.Count; i++)
            {
                MainControl.Controls[i].Width = MainControl.Width - 23;
            }
        }

        //Function used to populate items in the flow layout panel
        public void PopulateWithItems(User user)
        {
            for (int i = 0; i < 3; i++)
            {
                CartItem cartItem = new CartItem(new Product()
                {
                    Price = 100,
                    Promotion = 10
                });

                MainControl.Controls.Add(cartItem);
            }
        }

        //Event used to update the UI and calculate the pricing of the selected products
        public void UpdateOrderInfo(object sender, EventArgs e)
        {
            decimal selectedPrice = 0;
            decimal selectedDiscounts = 0;

            for (int i = 0; i < MainControl.Controls.Count; i++)
            {
                CartItem cartItem = ((CartItem)MainControl.Controls[i]);
                if (cartItem.Selected)
                {
                    selectedPrice += cartItem.Price * cartItem.Quantity;
                    selectedDiscounts += cartItem.Price * cartItem.Promotion / 100 * cartItem.Quantity;
                }
            }

            decimal totalPrice = selectedPrice - selectedDiscounts;

            labelSelected.Text = "$" + selectedPrice.ToString();
            labelDiscounts.Text = "-$" + selectedDiscounts.ToString();
            labelTotal.Text = "$" + totalPrice.ToString();
        }
    }
}
