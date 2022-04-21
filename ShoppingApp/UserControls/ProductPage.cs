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
using ShoppingApp.UserControls;
using ShoppingAppData;

namespace ShoppingApp.UserControls
{
    public partial class ProductPage : CustomPage, IProductsView
    {
        private readonly DataContext _dataContext = new DataContext();
        public ProductPage(Product product)
        {
            InitializeComponent();

            //Settings for initializing the Page
            TabPage tabPage = new TabPage(product.Brand.Trim() + " " + product.Model.Trim());
            tabPage.Controls.Add(this);
            FormApp.TabControl.Controls.Add(tabPage);
            FormApp.TabControl.SelectedTab = tabPage;

            MainControl = panel1;

            if (FormApp.User.RoleId == 1) buttonEdit.Visible = true;

            DisplayInfo(_dataContext.Products.Include(p => p.Category).First(p => p.Id == product.Id));
            ItemPage_Resize(this, new EventArgs());
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
            set { this.Product.Specifications = value.Trim(); labelSpecifications.Text = "Specifications: \n‣ " + this.Product.Specifications.Replace(", ", "\n‣ "); }
        }
        public decimal Price
        {
            get { return this.Product.Price; }
            set { this.Product.Price = value; labelPrice.Text = "$" + String.Format("{0:0.00}", this.Product.Price); }
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

        //Event that handles resizing of the Form
        private void ItemPage_Resize(object sender, EventArgs e)
        {
            if (MainControl == null) return;

            MainControl.Location = new Point(MainControl.Parent.Width / 2 - MainControl.Width / 2, MainControl.Parent.Height / 2 - MainControl.Height / 2);
        }

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
            Category = product.Category;
            Promotion = product.Promotion;
            Thumbnail = Thumbnail.Length > 1 ? product.Thumbnail : Converter.ToBinary(Properties.Resources.image_error);

            //Control settings
            if (Promotion > 0)
            {
                labelPromotion.Visible = true;
                labelPromotion.Text = "$" + Price.ToString("0.00");
                labelPrice.Text = "$" + (Price - Price * Promotion / 100).ToString("0.00");
            }
        }

        //Event that adds a product to the cart of the user in the database
        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart() 
            { 
                User = _dataContext.Users.FirstOrDefault(u => u.Id == FormApp.User.Id),
                Product = _dataContext.Products.Include(p => p.Category).FirstOrDefault(p => p.Id == Product.Id)
            };

            if (_dataContext.Carts.Include(c => c.User).Include(c => c.Product).FirstOrDefault(c => c.User.Id == cart.Id && c.Product.Id == cart.Id) != null)
            {
                MessageBox.Show("Item already added to cart.");
                return;
            }

            _dataContext.Carts.Add(cart);
            _dataContext.SaveChanges();
        }

        //Event that creates a page for editing a product when button is clicked
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditItemPage editItemPage = new EditItemPage(_dataContext.Products.Include(p => p.Category).First(p => p.Id == Product.Id));
        }

        //Event that closes the Page when button is clicked
        private void buttonClose_Click(object sender, EventArgs e)
        {
            FormApp.TabControl.SelectedIndex -= 1;
            FormApp.TabControl.TabPages.Remove((TabPage)this.Parent);
        }
    }
}
