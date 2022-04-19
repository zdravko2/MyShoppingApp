using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ShoppingApp.ViewInterfaces;
using ShoppingAppData.Models;

namespace ShoppingApp.UserControls.ItemPreviews
{
    public partial class ListingItem : UserControl, IProductsView
    {
        public ListingItem(Product product)
        {
            InitializeComponent();

            //Settings for initializing item control
            //Set main value
            Product = product;

            //Subscribe controls to OnClick event
            this.Click += OnClick;
            pictureBox1.Click += OnClick;
            labelTitle.Click += OnClick;
            labelSpecifications.Click += OnClick;
            labelPrice.Click += OnClick;
            labelPromotion.Click += OnClick;

            DisplayInfo(Product);
        }

        //Properties for the control
        #region Properties
        private Product Product { get; set; } = new Product();

        public int Id
        {
            get { return this.Product.Id; }
            set { this.Product.Id = value; }
        }
        public string Brand
        {
            get { return this.Product.Brand; }
            set { this.Product.Brand = value.Trim(); labelTitle.Text = this.Product.Brand + " " + this.Product.Model; }
        }
        public string Model
        {
            get { return this.Product.Model; }
            set { this.Product.Model = value.Trim(); labelTitle.Text = this.Product.Brand + " " + this.Product.Model; }
        }
        public string Specifications
        {
            get { return this.Product.Specifications; }
            set { this.Product.Specifications = value.Trim(); labelSpecifications.Text = "‣ " + this.Product.Specifications.Replace(", ", "\n‣ "); }
        }
        public decimal Price
        {
            get { return this.Product.Price; }
            set { this.Product.Price = value; labelPrice.Text = "$" + this.Product.Price.ToString("0.00"); }
        }
        public Category Category
        {
            get { return this.Product.Category; }
            set { this.Product.Category = value; }
        }
        public int Promotion
        {
            get { return this.Product.Promotion; }
            set { this.Product.Promotion = value; }
        }
        public Byte[] Thumbnail
        {
            get { return this.Product.Thumbnail; }
            set { this.Product.Thumbnail = value; pictureBox1.BackgroundImage = Converter.ToImage(this.Product.Thumbnail); }
        }
        #endregion

        //Function for updating the UI
        public void DisplayInfo(Product product)
        {
            //Update control values
            Id = product.Id;
            Brand = product.Brand.Trim();
            Model = product.Model.Trim();
            Specifications = product.Specifications.Trim();
            Price = product.Price;
            Category = product.Category;
            Promotion = product.Promotion;
            Thumbnail = Thumbnail.Length > 1 ? product.Thumbnail : Converter.ToBinary(Properties.Resources.image_error);

            //Control settings
            if (Promotion > 0)
            {
                labelPromotion.Visible = true;
                labelPromotion.Text = "$" + Price.ToString();
                labelPrice.Text = "$" + (Price - Price * Promotion / 100).ToString();
            }
        }

        //Event that handles clicking on the item
        private void OnClick(object sender, EventArgs e)
        {
            ProductPage productPage = new ProductPage(Product);
        }
    }
}
