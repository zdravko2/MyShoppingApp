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

namespace ShoppingApp.UserControls
{
    public partial class EditCategoryPage : CustomPage, ICategoryView
    {
        private readonly DataContext _dataContext = new DataContext();
        public EditCategoryPage()
        {
            InitializeComponent();

            TabPage tabPage = new TabPage("Add Category");
            tabPage.Controls.Add(this);
            FormApp.TabControl.Controls.Add(tabPage);
            FormApp.TabControl.SelectedTab = tabPage;

            buttonSave.Text = "Add Category";
            buttonDelete.Visible = false;
            MainControl = panel1;

            DisplayInfo(new Category());
        }
        public EditCategoryPage(Category category)
        {
            InitializeComponent();

            TabPage tabPage = new TabPage("Edit Category");
            tabPage.Controls.Add(this);
            FormApp.TabControl.Controls.Add(tabPage);
            FormApp.TabControl.SelectedTab = tabPage;

            buttonSave.Text = "Save Category";
            buttonDelete.Visible = true;
            MainControl = panel1;

            DisplayInfo(category);
        }


        #region Properties
        //Properties for the control
        private Category Category { get; set; } = new Category() { Id = -1 };

        public int Id
        {
            get { return this.Category.Id; }
            set { this.Category.Id = value; }
        }
        public string Title
        {
            get { return this.Category.Title; }
            set { this.Category.Title = value.Trim(); textBox1.Text = this.Category.Title; }
        }

        public Byte[] Thumbnail
        {
            get { return this.Category.Thumbnail; }
            set { this.Category.Thumbnail = value; pictureBox1.BackgroundImage = Converter.ToImage(Thumbnail); }
        }

        #endregion

        public void DisplayInfo(Category category)
        {
            //Set main value
            Category = category;

            //Update control values in the UI
            Id = category.Id;
            Title = category.Title;
            Thumbnail = Thumbnail.Length > 1 ? category.Thumbnail : Converter.ToBinary(Properties.Resources.image_error);
        }

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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = Title.ToString();
            pictureBox1.BackgroundImage = Converter.ToImage(Thumbnail);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to permanently delete this category and add every product from this category to category 'Uncategorized'?", "Delete category and products?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (_dataContext.Categories.Find(Category.Id) == null)
                {
                    MessageBox.Show("Category was not found.");
                    return;
                }
                else
                {
                    //Move the Products from this Category to Category "Uncategorized"
                    List<Product> products = _dataContext.Products.Where(p => p.CategoryId == Category.Id).ToList();

                    //Check if Category "Uncateogorized" exists
                    if (_dataContext.Categories.Where(c => c.Title == "Uncategorized").ToList().Count > 0)
                    {
                        Category temp = _dataContext.Categories.Where(c => c.Title == "Uncategorized").First();
                        products.ForEach(p => p.CategoryId = temp.Id);
                    }
                    else
                    {
                        Category temp = _dataContext.Categories.Add(new Category()
                        {
                            Title = "Uncategorized",
                            Thumbnail = Converter.ToBinary(Properties.Resources.icons8_category_100)
                        });
                        _dataContext.SaveChanges();

                        products.ForEach(p => p.CategoryId = _dataContext.Categories.Where(c => c.Title == "Uncategorized").First().Id);
                    }

                    //Remove Category from Category table
                    Category = _dataContext.Categories.Find(Category.Id);
                    if (Category.Title != "Uncategorized") _dataContext.Categories.Remove(Category);

                    _dataContext.SaveChanges().ToString();
                    MessageBox.Show("Category deleted successfully.");
                }

                //Opens a new page and frees resourses
                AddNewPage addNewPage = new AddNewPage();
                this.Parent.Parent.Controls.Remove(this.Parent);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Creating error arguments if there are any errors in the validation
            string errorArgs = string.Empty;

            if (textBox1.Text == String.Empty || textBox1.Text.Length >= 50) errorArgs += "Title is not set correctly.\n";
            if (Thumbnail == Converter.ToBinary(Properties.Resources.image_error)) errorArgs += "Thumbnail image is not set.";

            if (errorArgs != string.Empty)
            {
                MessageBox.Show(errorArgs, "Error");
                return;
            }

            //Checking if the category is new or if it already exists
            if (Category.Id == new Category().Id)
            {
                Category newCategory = new Category();

                newCategory.Id = Category.Id;
                newCategory.Title = textBox1.Text;
                newCategory.Thumbnail = Converter.ToBinary(pictureBox1.BackgroundImage);

                _dataContext.Categories.Add(newCategory);

                _dataContext.SaveChanges().ToString();
                MessageBox.Show("Category added successfully.");

                //Opens a page with the new category and frees resourses
                EditCategoryPage newEditCategoryPage = new EditCategoryPage(newCategory);
                this.Parent.Parent.Controls.Remove(this.Parent);
            }
            else
            {
                Category newCategory = _dataContext.Categories.Find(Category.Id);

                newCategory.Id = Category.Id;
                newCategory.Title = textBox1.Text;
                newCategory.Thumbnail = Converter.ToBinary(pictureBox1.BackgroundImage);

                Category = newCategory; //This updates the controls in the UI

                _dataContext.SaveChanges().ToString();
                MessageBox.Show("Item saved successfully.");
            }
        }
    }
}
