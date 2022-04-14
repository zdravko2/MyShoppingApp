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

namespace ShoppingApp
{
    public partial class FormLogin : Form
    {
        private readonly DataContext _dataContext = new DataContext();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            List<User> temp = _dataContext.Users.Where(u => u.Username == textBoxUsername.Text && u.Password == textBoxPassword.Text).ToList();

            //Checks if user exists
            if (temp.Count > 0)
            {
                User user = new User();
                user.Id = temp[0].Id;
                user.Username = temp[0].Username.Trim();
                user.Password = temp[0].Password.Trim();
                user.RoleId = temp[0].RoleId;

                //Opens the main app
                this.Hide();
                FormApp form = new FormApp(user);
                form.ShowDialog();
                this.Close();
            }
            else
            {
                labelError.Visible = true;
                labelError.Text = "Incorrect credentials";
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = textBoxUsername.Text;
            user.Password = textBoxPassword.Text;

            List<User> users = _dataContext.Users.Where(u => u.Username == textBoxUsername.Text).ToList();

            //Checks if user doesn't exist
            if (users.Count == 0)
            {
                _dataContext.Users.Add(user);
                _dataContext.SaveChanges();

                MessageBox.Show("Registration complete.");
            }
            else
            {
                labelError.Visible = true;
                labelError.Text = "Username already taken";
            }
        }
    }
}
