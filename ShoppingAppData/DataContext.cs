using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ShoppingAppData.Models;

namespace ShoppingAppData
{
    public class DataContext : DbContext
    {
        public DataContext() : base(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\ShoppingApp_Database.mdf; Integrated Security = True")
        {
            //if (!Database.Exists("dbo"))
            //{
            //    Database.SetInitializer(new DropCreateDatabaseAlways<DataContext>());
            //}
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
