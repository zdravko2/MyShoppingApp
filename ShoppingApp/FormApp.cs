using System.ComponentModel;
using ShoppingAppData.Models;
using ShoppingApp.ViewInterfaces;
using ShoppingApp.UserControls;
using ShoppingApp.UserControls.ItemPreviews;
using System.Windows.Forms;
using ShoppingAppData;
using System.Data.Entity;

namespace ShoppingApp
{
    public partial class FormApp : Form
    {
        public static User User;
        public static TabControl TabControl;
        public static TextBox SearchBar;
        private readonly DataContext _dataContext = new DataContext();

        public FormApp(User user)
        {
            InitializeComponent();

            //Static members
            User = user;
            TabControl = tabControlMain;
            SearchBar = textBox1;

            //TabControl settings
            tabControlMain.Dock = DockStyle.None;
            tabControlMain.ItemSize = new Size(0, 1);
            tabControlMain.SendToBack();
            ClearPages();
            FormApp_Resize(this, new EventArgs());

            //User UI settings
            buttonUser.Text = User.Username;
            if (User.RoleId == 1)
            {
                buttonAddNew.Visible = true;
                buttonUsersList.Visible = true;
                buttonOrdersList.Visible = true;
            }
        }

        //Event used to handle resizing of the form
        private void FormApp_Resize(object sender, EventArgs e)
        {
            tabControlMain.Location = new Point(panelMenu.Right - 4, panelTitle.Bottom - 5);
            tabControlMain.Size = new Size(Width - tabControlMain.Location.X - 12, Height - tabControlMain.Location.Y - 35);
        }

        //Event called whenever the page changes, then sets the title label text to the opened page name
        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.TabPages.Count == 0 || tabControlMain.TabPages[0] == null) return;

            labelTitle.Text = tabControlMain.SelectedTab.Text;
        }

        //Event that handles entering string in the search bar
        private void SearchBar_OnPressEnterDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.Handled = true;
            e.SuppressKeyPress = true;
            ClearPages();

            string[] searchArgs = FormApp.SearchBar.Text.Split(' ');
            List<Product> products = new List<Product>();

            for (int i = 0; i < searchArgs.Length; i++)
            {
                string tempArgs = searchArgs[i];
                if (i == 0)
                {
                    products.AddRange(_dataContext.Products.Include(p => p.Category).Where(p => DbFunctions.Like(p.Brand, "%" + tempArgs + "%")).ToList());
                    products.AddRange(_dataContext.Products.Include(p => p.Category).Where(p => DbFunctions.Like(p.Model, "%" + tempArgs + "%")).ToList());
                    products.AddRange(_dataContext.Products.Include(p => p.Category).Where(p => DbFunctions.Like(p.Category.Title, "%" + tempArgs + "%")).ToList());
                }
                else
                {
                    List<Product> tempList = new List<Product>();
                    tempList.AddRange(_dataContext.Products.Include(p => p.Category).Where(p => DbFunctions.Like(p.Brand, "%" + tempArgs + "%")).ToList());
                    tempList.AddRange(_dataContext.Products.Include(p => p.Category).Where(p => DbFunctions.Like(p.Model, "%" + tempArgs + "%")).ToList());
                    tempList.AddRange(_dataContext.Products.Include(p => p.Category).Where(p => DbFunctions.Like(p.Category.Title, "%" + tempArgs + "%")).ToList());

                    products = products.Where(p => tempList.Contains(p)).ToList();
                }
            }

            products = products.Distinct().ToList();

            ListingPage listingPage = new ListingPage(products);
        }

        //Used to clear unused pages and resourses
        private void ClearPages()
        {
            for (int i = 1; i < FormApp.TabControl.TabPages.Count; i++)
            {
                FormApp.TabControl.TabPages.RemoveAt(i);
            }
        }

        private void OnMenuButtonClick(object sender, EventArgs e)
        {
            //Preparing UI
            ClearPages();
            panelButtonIndex.Top = (sender as Button).Top;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            //Getting data from database and storing it in a list
            List<Product> products = _dataContext.Products.Include(p => p.Category).ToList();

            //Opening new Page and feeding with data
            ListingPage homePage = new ListingPage(products);
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            //Getting data from database and storing it in a list
            List<Category> categories = _dataContext.Categories.ToList();

            //Opening new Page and feeding with data
            CategoryPage categoryPage = new CategoryPage(categories);
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            //Opening a new Page with the current user
            CartPage cartPage = new CartPage(FormApp.User);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            //Opening new Page for creating an item
            AddNewPage addNewPage = new AddNewPage();
            //EditItemPage editItemPage = new EditItemPage();
        }

        //Button for logging out and switching users
        private void buttonUser_Click(object sender, EventArgs e)
        {
            //Creating a dialog with buttons
            DialogResult result = MessageBox.Show("Do you want to log out?", "Log out?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormLogin form = new FormLogin();
                form.ShowDialog();
                this.Close();
            }
        }

        private void buttonUsersList_Click(object sender, EventArgs e)
        {
            //Opening new Page for list of all users
            UsersListPage usersListPage = new UsersListPage();
        }

        private void buttonOrdersList_Click(object sender, EventArgs e)
        {
            //Opening new Page for list of all orders
            OrdersListPage ordersListPage = new OrdersListPage();
        }
    }
}