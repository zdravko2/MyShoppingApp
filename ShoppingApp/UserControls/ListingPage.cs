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
using ShoppingApp.ViewInterfaces;
using ShoppingApp.UserControls.ItemPreviews;
using ShoppingAppData;

namespace ShoppingApp.UserControls
{
    public partial class ListingPage : CustomPage
    {
        private readonly DataContext _dataContext = new DataContext();

        public ListingPage(List<Product> products)
        {
            InitializeComponent();

            //Settings for initializing the Page
            TabPage tabPage = new TabPage("Listing");
            tabPage.Controls.Add(this);
            FormApp.TabControl.Controls.Add(tabPage);
            FormApp.TabControl.SelectedTab = tabPage;

            MainControl = flowLayoutPanel1;

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += SelectaedIndexChanged;
            comboBox2.SelectedIndexChanged += SelectaedIndexChanged;
            comboBox3.SelectedIndexChanged += SelectaedIndexChanged;

            Products = products;
            pageIndex = 1;

            Sort();
            UpdatePageButtons();
            ListingPage_Resize(this, new EventArgs());
        }

        private int pageIndex;
        private List<Product> Products;

        //Event used to handle resizing of the Form
        private void ListingPage_Resize(object sender, EventArgs e)
        {
            //panel1.Size = new Size(Size.Width * 3 / 9, panel1.Size.Height);
            if (MainControl == null) return;

            ListingItem panel = new ListingItem(new Product());

            int offset = 10;
            if (MainControl.Controls.Count > (MainControl.Size.Width / (panel.Width + offset)))
            {
                int newPadding = MainControl.Size.Width - offset - (MainControl.Size.Width / (panel.Width + offset) * (panel.Width + offset));
                MainControl.Padding = new Padding(newPadding / 2, 0, newPadding / 2, 0);
            }
            else
            {
                int newPadding = MainControl.Size.Width - offset - MainControl.Controls.Count * (panel.Width + offset * 2);
                MainControl.Padding = new Padding(newPadding / 2, 0, newPadding / 2, 0);
            }
        }

        //Algorythm for updating buttons for pages
        public void UpdatePageButtons()
        {
            int lastPageIndex = ((Products.Count - 1) / Convert.ToInt32(comboBox3.Text) + 1);
            buttonLastPage.Text = "" + lastPageIndex;

            if (lastPageIndex > 1)
            {
                if (pageIndex <= 4)
                {
                    if (2 < lastPageIndex) 
                    { button1.Text = "" + (2); button1.Enabled = true; }
                    else { button1.Text = ""; button1.Enabled = false; }
                    if (3 < lastPageIndex)
                    { button2.Text = "" + (3); button2.Enabled = true; }
                    else { button2.Text = ""; button2.Enabled = false; }
                    if (4 < lastPageIndex)
                    { button3.Text = "" + (4); button3.Enabled = true; }
                    else { button3.Text = ""; button3.Enabled = false; }
                    if (5 < lastPageIndex)
                    { button4.Text = "" + (5); button4.Enabled = true; }
                    else { button4.Text = ""; button4.Enabled = false; }
                    if (6 < lastPageIndex)
                    { button5.Text = "" + (6); button5.Enabled = true; }
                    else { button5.Text = ""; button5.Enabled = false; }
                }
                else if (pageIndex > lastPageIndex - 3 && pageIndex < 7)
                {
                    if (2 < lastPageIndex)
                    { button1.Text = "" + (2); button1.Enabled = true; }
                    else { button1.Text = ""; button1.Enabled = false; }
                    if (3 < lastPageIndex)
                    { button2.Text = "" + (3); button2.Enabled = true; }
                    else { button2.Text = ""; button2.Enabled = false; }
                    if (4 < lastPageIndex)
                    { button3.Text = "" + (4); button3.Enabled = true; }
                    else { button3.Text = ""; button3.Enabled = false; }
                    if (5 < lastPageIndex)
                    { button4.Text = "" + (5); button4.Enabled = true; }
                    else { button4.Text = ""; button4.Enabled = false; }
                    if (6 < lastPageIndex)
                    { button5.Text = "" + (6); button5.Enabled = true; }
                    else { button5.Text = ""; button5.Enabled = false; }
                }
                else if (pageIndex > lastPageIndex - 3)
                {
                    button1.Text = "" + (lastPageIndex - 5); button1.Enabled = true;
                    button2.Text = "" + (lastPageIndex - 4); button2.Enabled = true;
                    button3.Text = "" + (lastPageIndex - 3); button3.Enabled = true;
                    button4.Text = "" + (lastPageIndex - 2); button4.Enabled = true;
                    button5.Text = "" + (lastPageIndex - 1); button5.Enabled = true;
                }
                else
                {
                    button1.Text = "" + (pageIndex - 2); button1.Enabled = true;
                    button2.Text = "" + (pageIndex - 1); button2.Enabled = true;
                    button3.Text = "" + (pageIndex - 0); button3.Enabled = true;
                    button4.Text = "" + (pageIndex + 1); button4.Enabled = true;
                    button5.Text = "" + (pageIndex + 2); button5.Enabled = true;
                }
            }
            else
            {
                button1.Text = ""; button1.Enabled = false;
                button2.Text = ""; button2.Enabled = false;
                button3.Text = ""; button3.Enabled = false;
                button4.Text = ""; button4.Enabled = false;
                button5.Text = ""; button5.Enabled = false;
                buttonLastPage.Text = ""; buttonLastPage.Enabled = false;
            }

            PopulateWithItems(Products);
        }

        //Function used to populate items in the flow layout panel
        public void PopulateWithItems(List<Product> products)
        {
            MainControl.Controls.Clear();

            for (int i = (pageIndex - 1) * Convert.ToInt32(comboBox3.Text); i < products.Count && i < (pageIndex) * Convert.ToInt32(comboBox3.Text); i++)
            {
                ListingItem listingItem = new ListingItem(_dataContext.Products.Find(products[i].Id));
                MainControl.Controls.Add(listingItem);
            }
        }

        private void pageButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            pageIndex = Convert.ToInt32(button.Text);
            UpdatePageButtons();
        }

        //Event that handles every change in the sorting options
        private void SelectaedIndexChanged(object sender, EventArgs e)
        {
            Sort();

            pageIndex = 1;
            UpdatePageButtons();
        }

        //Sorts the list of products by the selected method
        private void Sort()
        {
            switch (comboBox2.SelectedIndex)
            {
                //Sorting by promotions first then by brand name
                case 0:
                    Products = (from product in Products
                                orderby product.Promotion, product.Brand.ToLower()
                                select product).ToList(); Products.Reverse(); break;
                //Sorting by brand name
                case 1:
                    Products = (from product in Products
                                orderby product.Brand.ToLower()
                                select product).ToList(); break;
                //Sorting by price with promotion
                case 2:
                    Products = (from product in Products
                                orderby product.Price - product.Price * product.Promotion / 100
                                select product).ToList(); break;
            }

            //Checks if the order should be ascending or descending
            if (comboBox1.SelectedIndex == 1)
            {
                Products.Reverse();
            }
        }
    }
}
