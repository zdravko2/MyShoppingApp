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

using ShoppingAppData;
using ShoppingAppData.Models;
using ShoppingApp.ViewInterfaces;

namespace ShoppingApp.UserControls.ItemPreviews
{
    public partial class OrderItem : UserControl, IOrderView
    {
        private readonly DataContext _dataContext = new DataContext();
        public OrderItem(Order order)
        {
            InitializeComponent();

            //Set main value
            Order = order;

            DisplayInfo(Order);
        }


        //Properties for the control
        #region Properties
        private Order Order { get; set; } = new Order();

        public int Id
        {
            get { return this.Order.Id; }
            set { this.Order.Id = value; labelId.Text = this.Order.Id.ToString(); }
        }
        public User User
        {
            get { return this.Order.User; }
            set { this.Order.User = value;
                User u = _dataContext.Users.Find(this.Order.User.Id);
                if (u != null) labelUsername.Text = u.Username.Trim();
                else labelUsername.Text = "*Deleted User*";
            }
        }
        public Product Product
        {
            get { return this.Order.Product; }
            set { this.Order.Product = value; 
                Product p = _dataContext.Products.Find(this.Order.Product.Id);
                if (p != null) labelProduct.Text = p.Brand.Trim() + " " + p.Model.Trim();
                else labelProduct.Text = "*Deleted Product*";
            }
        }
        public int Quantity
        {
            get { return this.Order.Quantity; }
            set { this.Order.Quantity = value; labelQuantity.Text = Quantity.ToString(); }
        }
        #endregion

        //Function for updating the UI
        public void DisplayInfo(Order order)
        {
            //Update control values
            Id = order.Id;
            User = order.User;
            Product = order.Product;
            Quantity = order.Quantity;
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {
            //Opens OrdersListPage for the selected user
            User user = _dataContext.Users.FirstOrDefault(u => u.Id == this.Order.User.Id);
            OrdersListPage ordersListPage = new OrdersListPage(user);
        }

        private void labelProduct_Click(object sender, EventArgs e)
        {
            //Opens ProductPage for the product
            Product product = _dataContext.Products.Include(p => p.Category).FirstOrDefault(p => p.Id == this.Order.Product.Id);
            ProductPage productPage = new ProductPage(product);
        }
    }
}
