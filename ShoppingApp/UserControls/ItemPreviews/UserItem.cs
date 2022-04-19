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
using ShoppingApp.ViewInterfaces;

namespace ShoppingApp.UserControls.ItemPreviews
{
    public partial class UserItem : UserControl, IUsersView
    {
        private readonly DataContext _dataContext = new DataContext();
        public UserItem(User user)
        {
            InitializeComponent();

            //Setting main value of the control
            User = user;

            DisplayInfo(User);
        }

        //Properties for the control
        #region Properties
        private User User { get; set; } = new User();

        public int Id
        {
            get { return this.User.Id; }
            set { this.User.Id = value; labelId.Text = this.User.Id.ToString(); }
        }
        public string Username
        {
            get { return this.User.Username; }
            set { this.User.Username = value.Trim(); labelUsername.Text = this.User.Username; }
        }
        public int RoleId
        {
            get { return this.User.RoleId; }
            set { this.User.RoleId = value; switch (User.RoleId) 
                {   case 0: labelRole.Text = "User"; break;
                    case 1: labelRole.Text = "Admin"; break;
                    default: labelRole.Text = "Undefined"; break;
                } 
            }
        }
        #endregion

        //Function for updating the UI
        public void DisplayInfo(User user)
        {
            //Set main value
            User = user;

            //Update control values
            Id = user.Id;
            Username = user.Username;
            RoleId = user.RoleId;
        }

        private void OnClick(object sender, EventArgs e)
        {
            MessageBox.Show(Username + " " + RoleId);
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {
            //Opens OrdersListPage for the selected user
            User user = _dataContext.Users.FirstOrDefault(u => u.Id == this.User.Id);
            OrdersListPage ordersListPage = new OrdersListPage(user);
        }

        private void labelRole_Click(object sender, EventArgs e)
        {
            if (this.User.Id == FormApp.User.Id)
            {
                MessageBox.Show("You can not change your permissions.", "Error");
                return;
            }

            if (User.RoleId == 0)
            {
                //Creating a dialog with buttons
                DialogResult result = MessageBox.Show("Do you want to change this user's permissions to Admin?", "Change user permissions", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    User user = _dataContext.Users.FirstOrDefault(u => u.Id == this.User.Id);
                    user.RoleId = 1;
                    _dataContext.SaveChanges();
                }
            }
            else if (User.RoleId == 1)
            {
                //Creating a dialog with buttons
                DialogResult result = MessageBox.Show("Do you want to change this user's permissions to User?", "Change user permissions", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    User user = _dataContext.Users.FirstOrDefault(u => u.Id == this.User.Id);

                    user.RoleId = 0;
                    _dataContext.SaveChanges();
                }
            }

            //Reopens page to update info and save resourses
            UsersListPage usersListPage = new UsersListPage();
            this.Parent.Parent.Controls.Remove(this.Parent);
        }
    }
}
