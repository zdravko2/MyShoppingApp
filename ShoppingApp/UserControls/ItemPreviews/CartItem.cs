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
using ShoppingAppData;

namespace ShoppingApp.UserControls.ItemPreviews
{
    public partial class CartItem : UserControl, IProductsView
    {
        private readonly DataContext _dataContext = new DataContext();
        public CartItem(Product product)
        {
            InitializeComponent();

            //Settings for initializing item control
            //Subscribe controls to OnClick event
            this.Click += OnClick;
            pictureBox1.Click += OnClick;
            labelTitle.Click += OnClick;
            labelPrice.Click += OnClick;
            labelPromotion.Click += OnClick;

            DisplayInfo(product);
        }


        //Properties for the control
        #region Properties
        public int Quantity
        {
            get { return int.Parse(this.comboBoxQuantity.Text == "" ? "0" : this.comboBoxQuantity.Text); }
            set { this.comboBoxQuantity.Text = value.ToString(); }
        }
        public bool Selected
        {
            get { return checkBoxSelected.Checked; }
            set { checkBoxSelected.Checked = value; }
        }

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
            set { this.Product.Specifications = value.Trim(); }
        }
        public decimal Price
        {
            get { return this.Product.Price; }
            set { this.Product.Price = value; labelPrice.Text = "$" + this.Product.Price.ToString("0.00"); }
        }
        public int CategoryId
        {
            get { return this.Product.CategoryId; }
            set { this.Product.CategoryId = value; }
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
            //Set main value
            Product = product;

            //Update control values
            Id = product.Id;
            Brand = product.Brand.Trim();
            Model = product.Model.Trim();
            Specifications = product.Specifications.Trim();
            Price = product.Price;
            CategoryId = product.CategoryId;
            Promotion = product.Promotion;
            Thumbnail = Thumbnail.Length > 1 ? product.Thumbnail : Converter.ToBinary(Properties.Resources.image_error);

            //Control settings
            Selected = true;
            if (Promotion > 0)
            {
                labelPromotion.Visible = true;
                labelPromotion.Text = "$" + Price.ToString();
                labelPrice.Text = "$" + (Price - Price * Promotion / 100).ToString();
            }
        }

        private void OnClick(object sender, EventArgs e)
        {
            ProductPage productPage = new ProductPage(Product);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Cart cart = _dataContext.Carts.Where(c => c.UserId == FormApp.User.Id && c.ProductId == Product.Id).ToList().First();

            if (cart != null)
            {
                _dataContext.Carts.Remove(cart);
                _dataContext.SaveChanges();

                Parent.Controls.Remove(this);
            }
        }

        private void comboBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            int result;

            if (!int.TryParse(comboBoxQuantity.Text, out result))
            {
                comboBoxQuantity.Text = "0";
            }
        }
    }
}
