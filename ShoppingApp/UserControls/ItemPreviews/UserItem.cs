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

namespace ShoppingApp.UserControls.ItemPreviews
{
    public partial class UserItem : UserControl
    {
        public UserItem(User user)
        {
            InitializeComponent();

            //Setting main value of the control
            User = user;

            labelId.Click += OnClick;
            labelUsername.Click += OnClick;
            labelRole.Click += OnClick;

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
            get { return this.User.Id; }
            set { this.User.Id = value; switch (User.Id) 
                {   case 0: labelRole.Text = "User"; break;
                    case 1: labelRole.Text = "Admin"; break;
                } 
            }
        }
        #endregion

        //Function for updating the UI
        public void DisplayInfo(User user)
        {
            //Update control values
            Id = user.Id;
            Username = user.Username;
            RoleId = user.RoleId;
        }

        private void OnClick(object sender, EventArgs e)
        {
            MessageBox.Show(Username + " " + RoleId);
        }
    }
}
