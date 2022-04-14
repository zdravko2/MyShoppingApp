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
using ShoppingAppData;
using ShoppingApp.ViewInterfaces;

namespace ShoppingApp.UserControls
{
    public partial class EditItemPage : CustomPage, IProductsView
    {
        private readonly DataContext _dataContext = new DataContext();

        //Constructor for creating a new item
        public EditItemPage()
        {
            InitializeComponent();

            //Settings for initializing the Page
            TabPage tabPage = new TabPage("Add Product");
            tabPage.Controls.Add(this);
            FormApp.TabControl.Controls.Add(tabPage);
            FormApp.TabControl.SelectedTab = tabPage;

            buttonCreate.Text = "Add Product";
            buttonDelete.Visible = false;
            MainControl = panel1;

            //Filling autocomplete source for Brands and Categories
            FillAutocompleteSource();

            DisplayInfo(new Product());
        }

        //Constructor editing an existing item
        public EditItemPage(Product product)
        {
            InitializeComponent();

            //Settings for initializing the Page
            TabPage tabPage = new TabPage("Edit Product");
            tabPage.Controls.Add(this);
            FormApp.TabControl.Controls.Add(tabPage);
            FormApp.TabControl.SelectedTab = tabPage;

            buttonCreate.Text = "Update Product";
            buttonDelete.Visible = true;
            MainControl = panel1;

            //Filling autocomplete source for Brands and Categories
            FillAutocompleteSource();

            DisplayInfo(_dataContext.Products.Find(product.Id));
        }


        #region Properties
        //Properties for the control
        private Product Product { get; set; } = new Product() { Id = -1 };

        public int Id
        {
            get { return this.Product.Id; }
            set { this.Product.Id = value; }
        }
        public string Brand
        {
            get { return this.Product.Brand; }
            set { this.Product.Brand = value.Trim(); textBox1.Text = this.Product.Brand; }
        }
        public string Model
        {
            get { return this.Product.Model; }
            set { this.Product.Model = value.Trim(); textBox2.Text = this.Product.Model; }
        }
        public string Specifications
        {
            get { return this.Product.Specifications; }
            set { this.Product.Specifications = value.Replace("\n", "").Trim(); richTextBox1.Text = this.Product.Specifications; }
        }
        public decimal Price
        {
            get { return this.Product.Price; }
            set { this.Product.Price = value; textBox3.Text = this.Product.Price.ToString("0.00"); }
        }
        public int CategoryId
        {
            get { return this.Product.CategoryId; }
            set { this.Product.CategoryId = value;
                Category c = _dataContext.Categories.Find(this.Product.CategoryId);
                if (c != null)  comboBox1.SelectedItem = c.Title;
                else            comboBox1.SelectedItem = string.Empty;
            }
        }
        public int Promotion
        {
            get { return this.Product.Promotion; }
            set { this.Product.Promotion = value; textBox5.Text = this.Product.Promotion.ToString(); }
        }
        public Byte[] Thumbnail
        {
            get { return this.Product.Thumbnail; }
            set { this.Product.Thumbnail = value; pictureBox1.BackgroundImage = Converter.ToImage(this.Product.Thumbnail); }
        }
        #endregion


        //Event used to handle resizing of the Form
        private void AddNewPage_Resize(object sender, EventArgs e)
        {
            if (MainControl == null) return;

            MainControl.Location = new Point(MainControl.Parent.Width / 2 - MainControl.Width / 2, MainControl.Parent.Height / 2 - MainControl.Height / 2);
        }

        public void FillAutocompleteSource()
        {
            //Filling autocomplete source for Brands and Categories
            textBox1.AutoCompleteCustomSource.AddRange(_dataContext.Products.Select(p => p.Brand.Trim()).Distinct().ToArray());
            comboBox1.Items.AddRange(_dataContext.Categories.Select(c => c.Title.Trim()).ToList().ToArray());
        }

        public void DisplayInfo(Product product)
        {
            //Set main value
            Product = product;

            //Update control values in the UI
            Id = product.Id;
            Brand = product.Brand;
            Model = product.Model;
            Specifications = product.Specifications;
            Price = product.Price;
            CategoryId = product.CategoryId;
            Promotion = product.Promotion;
            Thumbnail = Thumbnail.Length > 1 ? product.Thumbnail : Converter.ToBinary(Properties.Resources.image_error);
        }

        //Button for uploading an thumbnail image for the item
        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image File|*.jpg;*.jpeg;*.png;...";
                dialog.Title = "Choose image file";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.BackgroundImage = new Bitmap(dialog.FileName);
                }
            }
        }

        //Button to reset the values of the controls to their initial values
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = Brand;
            textBox2.Text = Model;
            richTextBox1.Text = Specifications;
            textBox3.Text = Price.ToString();
            comboBox1.Text = _dataContext.Categories.Find(CategoryId).Title;
            textBox5.Text = Promotion.ToString();
            pictureBox1.BackgroundImage = Converter.ToImage(Thumbnail);
        }

        //Button for creating a new item and validation, then adding it to the database
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            //Creating error arguments if there are any errors in the validation
            textBox3.Text = textBox3.Text.Replace(".", ",");
            string errorArgs = string.Empty;
            if (pictureBox1.BackgroundImage == Properties.Resources.image_error) MessageBox.Show("");//errorArgs += "Thumbnail image is not set.\n";
            if (textBox1.Text == "") errorArgs += "Brand is not declared.\n";
            if (textBox2.Text == "") errorArgs += "Model is not declared.\n";
            if (richTextBox1.Text == "") errorArgs += "Specifications are not declared.\n";
            if (textBox3.Text == "") errorArgs += "Price is not declared.\n";
            if (comboBox1.Text == "") errorArgs += "Category is not declared.\n";
            if (textBox5.Text == "") errorArgs += "Promotion is not declared.\n";
            if (!int.TryParse(textBox5.Text.Trim(), out int result1) && result1 >= 0 && result1 < 100) errorArgs += "Promotion should be an integer from 0 to 99.\n";
            if (!decimal.TryParse(textBox3.Text.Trim(), out decimal result2) || result2 == 0) errorArgs += "Price is not set correctly.\n";
            if (Thumbnail == Converter.ToBinary(Properties.Resources.image_error)) errorArgs += "Thumbnail image is not set.";

            if (errorArgs != string.Empty)
            {
                MessageBox.Show(errorArgs, "Error");
                return;
            }

            //Checking if the product is new or if it already exists
            if (Product.Id == new Product().Id)
            {
                Product newProduct = new Product();

                newProduct.Id = Product.Id;
                newProduct.Brand = textBox1.Text;
                newProduct.Model = textBox2.Text;
                newProduct.Specifications = richTextBox1.Text;
                newProduct.Price = Convert.ToDecimal(textBox3.Text);
                newProduct.CategoryId = _dataContext.Categories.First(c => c.Title == comboBox1.Text).Id;
                newProduct.Promotion = Convert.ToInt32(textBox5.Text);
                newProduct.Thumbnail = Converter.ToBinary(pictureBox1.BackgroundImage);

                _dataContext.Products.Add(newProduct);

                _dataContext.SaveChanges().ToString();
                MessageBox.Show("Item added successfully.");

                //Opens a page with the new product and frees resourses
                EditItemPage newEditItemPage = new EditItemPage(newProduct);
                this.Parent.Parent.Controls.Remove(this.Parent);
            }
            else
            {
                Product newProduct = _dataContext.Products.Find(Product.Id);

                newProduct.Id = Product.Id;
                newProduct.Brand = textBox1.Text;
                newProduct.Model = textBox2.Text;
                newProduct.Specifications = richTextBox1.Text;
                newProduct.Price = Convert.ToDecimal(textBox3.Text);
                newProduct.CategoryId = _dataContext.Categories.First(c => c.Title == comboBox1.Text).Id;
                newProduct.Promotion = Convert.ToInt32(textBox5.Text);
                newProduct.Thumbnail = Converter.ToBinary(pictureBox1.BackgroundImage);

                Product = newProduct; //This updates the controls in the UI

                _dataContext.SaveChanges().ToString();
                MessageBox.Show("Item saved successfully.");
            }
        }

        //Button for deletion of item from the database
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to permanently delete this product?", "Delete product?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (_dataContext.Products.Find(Product.Id) == null)
                {
                    MessageBox.Show("Item was not found.");
                    return;
                }
                else
                {
                    //Remove Carts from Carts table where there is this Product
                    List<Cart> carts = _dataContext.Carts.Where(c => c.ProductId == Product.Id).ToList();
                    _dataContext.Carts.RemoveRange(carts);

                    //Remove products from Orders table
                    List<Order> orders = _dataContext.Orders.Where(o => o.ProductId == Product.Id).ToList();
                    _dataContext.Orders.RemoveRange(orders);

                    //Remove product from Product table
                    _dataContext.Products.Remove(Product);

                    _dataContext.SaveChanges().ToString();
                    MessageBox.Show("Item deleted successfully.");
                }

                //Opens a new blank page and frees resourses
                EditItemPage newEditItemPage = new EditItemPage();
                this.Parent.Parent.Controls.Remove(this.Parent);
            }
        }

        //Event that closes the Page when button is clicked
        private void buttonClose_Click(object sender, EventArgs e)
        {
            FormApp.TabControl.SelectedIndex -= 1;
            FormApp.TabControl.TabPages.Remove((TabPage)this.Parent);
        }
    }
}
