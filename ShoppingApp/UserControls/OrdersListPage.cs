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
using ShoppingApp.UserControls.ItemPreviews;

namespace ShoppingApp.UserControls
{
    public partial class OrdersListPage : CustomPage
    {
        private readonly DataContext _dataContext = new DataContext();
        public OrdersListPage()
        {
            InitializeComponent();

            //Settings for initializing the Page
            TabPage tabPage = new TabPage("Orders list");
            tabPage.Controls.Add(this);
            FormApp.TabControl.Controls.Add(tabPage);
            FormApp.TabControl.SelectedTab = tabPage;

            MainControl = flowLayoutPanel1;

            List<Order> orders = _dataContext.Orders.Include(o => o.User).Include(o => o.Product).ToList();
            PopulateWithItems(orders);
            OrdersListPage_Resize(this, new EventArgs());
        }

        public OrdersListPage(User user)
        {
            InitializeComponent();

            //Settings for initializing the Page
            TabPage tabPage = new TabPage("Orders list for user: " + _dataContext.Users.FirstOrDefault(u => u.Id == user.Id).Username);
            tabPage.Controls.Add(this);
            FormApp.TabControl.Controls.Add(tabPage);
            FormApp.TabControl.SelectedTab = tabPage;

            MainControl = flowLayoutPanel1;

            List<Order> orders = _dataContext.Orders.Include(o => o.User).Include(o => o.Product).Where(o => o.User.Id == _dataContext.Users.FirstOrDefault(u => u.Id == user.Id).Id).ToList();
            PopulateWithItems(orders);
            OrdersListPage_Resize(this, new EventArgs());
        }

        //Event used to handle resizing of the Form
        private void OrdersListPage_Resize(object sender, EventArgs e)
        {
            if (MainControl == null) return;

            for (int i = 0; i < MainControl.Controls.Count; i++)
            {
                MainControl.Controls[i].Width = MainControl.Width - 25;
            }
        }

        //Function used to populate items in the flow layout panel
        public void PopulateWithItems(List<Order> orders)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                OrderItem orderItem = new OrderItem(orders[i]);
                MainControl.Controls.Add(orderItem);
            }
        }
    }
}
