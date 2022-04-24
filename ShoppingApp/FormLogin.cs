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

        //Event for button for login
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            User user = _dataContext.Users.FirstOrDefault(u => u.Username == textBoxUsername.Text && u.Password == textBoxPassword.Text);

            //Checks if user exists and logs in the user
            if (user != null && user.Username.Trim() == textBoxUsername.Text && user.Password.Trim() == textBoxPassword.Text)
            {
                user.Username = user.Username.Trim();
                user.Password = user.Password.Trim();

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

        //Event for button for registration
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            User user = _dataContext.Users.FirstOrDefault(u => u.Username == textBoxUsername.Text);

            //Checks if user doesn't exist and registers the information
            if (user == null || user.Username.Trim() != textBoxUsername.Text)
            {
                _dataContext.Users.Add(new User()
                {
                    Username = textBoxUsername.Text,
                    Password = textBoxPassword.Text,
                    RoleId = 0
                });
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
