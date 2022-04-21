using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoppingAppData;
using ShoppingAppData.Models;

namespace ShoppingApp.UserControls
{
    public partial class AddNewPage : CustomPage
    {
        private readonly DataContext _dataContext = new DataContext();
        public AddNewPage()
        {
            InitializeComponent();

            //Settings for initializing the Page
            TabPage tabPage = new TabPage("Add new Product or Category");
            tabPage.Controls.Add(this);
            FormApp.TabControl.Controls.Add(tabPage);
            FormApp.TabControl.SelectedTab = tabPage;

            comboBox1.SelectedIndex = 0;
            MainControl = panel1;

            //Filling items to the combobox for Categories
            comboBox1.Items.AddRange(_dataContext.Categories.Select(c => c.Title.Trim()).ToList().ToArray());
        }


        //Event used to handle resizing of the Form
        private void AddNewPage_Resize(object sender, EventArgs e)
        {
            if (MainControl == null) return;
            MainControl.Location = new Point(MainControl.Parent.Width / 2 - MainControl.Width / 2, MainControl.Parent.Height / 2 - MainControl.Height / 2);
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            //Opens a new page for listing of all products
            ListingPage listingPage = new ListingPage(_dataContext.Products.ToList());
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            //Opens a new page for adding a new product
            EditItemPage editItemPage = new EditItemPage();
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            //Checks if the selected value is a new category
            if (comboBox1.SelectedIndex == 0)
            {
                //Opens new page for editing a new category
                EditCategoryPage editCategoryPage = new EditCategoryPage();
            }
            else
            {
                Category category = _dataContext.Categories.Where(c => c.Title == comboBox1.Text).First();

                if (category == null)
                {
                    MessageBox.Show("Could not find category.", "Error");
                    return;
                }

                //Opens new page for editing an existing category
                category.Title = category.Title.Trim();
                EditCategoryPage editCategoryPage = new EditCategoryPage(category);
            }    
        }
    }
}
