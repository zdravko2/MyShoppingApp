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

using ShoppingAppData.Models;
using ShoppingApp.ViewInterfaces;
using ShoppingApp.UserControls.ItemPreviews;
using ShoppingAppData;

namespace ShoppingApp.UserControls
{
    public partial class CategoryPage : CustomPage
    {
        private readonly DataContext _dataContext = new DataContext();
        public CategoryPage(List<Category> categories)
        {
            InitializeComponent();

            //Settings for initializing the Page
            TabPage tabPage = new TabPage("Categories");
            tabPage.Controls.Add(this);
            FormApp.TabControl.Controls.Add(tabPage);
            FormApp.TabControl.SelectedTab = tabPage;

            MainControl = flowLayoutPanel1;

            categories.ForEach(c => c.Title.Trim());

            PopulateWithItems(categories);
            CategoryPage_Resize(this, new EventArgs());
        }

        //Event used to handle resizing of the Form
        private void CategoryPage_Resize(object sender, EventArgs e)
        {
            if (MainControl == null) return;

            CategoryItem panel = new CategoryItem(new Category());

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

        //Function used to populate items in the flow layout panel
        public void PopulateWithItems(List<Category> categories)
        {
            //Creating new category item for promotions
            PromotionCategoryItem promotionCategoryItem = new PromotionCategoryItem();
            MainControl.Controls.Add(promotionCategoryItem);

            //Creating new category items from the avaliable categories
            for (int i = 0; i < categories.Count; i++)
            {
                CategoryItem categoryItem = new CategoryItem(_dataContext.Categories.Find(categories[i].Id));
                MainControl.Controls.Add(categoryItem);
            }
        }
    }
}
