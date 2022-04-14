using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ShoppingAppData;
using ShoppingAppData.Models;
using ShoppingApp.ViewInterfaces;
using ShoppingApp.UserControls.ItemPreviews;

namespace ShoppingApp.UserControls
{
    public partial class CartPage : CustomPage
    {
        private readonly DataContext _dataContext = new DataContext();
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
            List<Cart> cartlist = _dataContext.Carts.Where(c => c.UserId == user.Id).ToList();

            for (int i = 0; i < cartlist.Count; i++)
            {
                Product product = _dataContext.Products.Find(cartlist[i].ProductId);

                CartItem cartItem = new CartItem(product);
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

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (MainControl.Controls.Count == 0)
            {
                MessageBox.Show("You do not have any items in your cart.", "Error");
                return;
            }
            for (int i = 0; i < MainControl.Controls.Count; i++)
            {
                if (((CartItem)MainControl.Controls[i]).Selected)
                {
                    Order order = new Order();
                    order.UserId = FormApp.User.Id;
                    order.ProductId = ((CartItem)MainControl.Controls[i]).Id;
                    order.Quantity = ((CartItem)MainControl.Controls[i]).Quantity;

                    if (_dataContext.Users.Find(order.UserId) == null || _dataContext.Products.Find(order.ProductId) == null)
                    {
                        MessageBox.Show("There was a problem when creating the order.", "Error");
                    }
                    else
                    {
                        MessageBox.Show("Order added successfully");
                    }
                    _dataContext.Orders.Add(order);
                    _dataContext.SaveChanges();
                }
            }
        }
    }
}
