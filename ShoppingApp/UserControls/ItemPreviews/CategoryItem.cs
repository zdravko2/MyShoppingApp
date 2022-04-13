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
using ShoppingAppData;

namespace ShoppingApp.UserControls.ItemPreviews
{
    public partial class CategoryItem : UserControl
    {
        private readonly DataContext _dataContext = new DataContext();
        public CategoryItem(Category category)
        {
            InitializeComponent();

            //Settings for initializing item control
            this.Category = category;

            DisplayInfo(Category);
        }

        #region Properties

        private Category Category;

        public int Id
        {
            get { return this.Category.Id; }
            set { this.Category.Id = value; }
        }
        public string Title
        {
            get { return this.Category.Title; }
            set { this.Category.Title = value.Trim(); labelTitle.Text = value; }
        }
        public Byte[] Thumbnail
        {
            get { return this.Category.Thumbnail; }
            set { this.Category.Thumbnail = value; }
        }

        #endregion

        //Function for updating the UI
        public void DisplayInfo(Category category)
        {
            //Update control values
            Id = category.Id;
            Title = category.Title;
            Thumbnail = category.Thumbnail;
        }

        //Event that handles clicking on the item
        private void OnClick(object sender, EventArgs e)
        {
            List<Product> products = _dataContext.Products.Where(p => p.CategoryId == this.Category.Id).ToList();
            ListingPage listingPage = new ListingPage(products);
        }
    }
}
