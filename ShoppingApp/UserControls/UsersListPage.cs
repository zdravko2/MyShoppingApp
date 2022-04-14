using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoppingAppData;
using ShoppingAppData.Models;
using ShoppingApp.UserControls.ItemPreviews;

namespace ShoppingApp.UserControls
{
    public partial class UsersListPage : CustomPage
    {
        private readonly DataContext _dataContext = new DataContext();
        public UsersListPage()
        {
            InitializeComponent();

            //Settings for initializing the Page
            TabPage tabPage = new TabPage("Users list");
            tabPage.Controls.Add(this);
            FormApp.TabControl.Controls.Add(tabPage);
            FormApp.TabControl.SelectedTab = tabPage;

            MainControl = flowLayoutPanel1;

            List<User> users = _dataContext.Users.ToList();
            PopulateWithItems(users);
            UserListPage_Resize(this, new EventArgs());
        }


        //Event used to handle resizing of the Form
        private void UserListPage_Resize(object sender, EventArgs e)
        {
            if (MainControl == null) return;

            for (int i = 0; i < MainControl.Controls.Count; i++)
            {
                MainControl.Controls[i].Width = MainControl.Width - 15;
            }
        }

        //Function used to populate items in the flow layout panel
        public void PopulateWithItems(List<User> users)
        {
            for (int i = 0; i < users.Count; i++)
            {
                UserItem userItem = new UserItem(users[i]);
                MainControl.Controls.Add(userItem);
            }
        }
    }
}
