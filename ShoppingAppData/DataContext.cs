﻿using System.Data.Entity;
using ShoppingAppData.Models;

#pragma warning disable CS8618, CS8602 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace ShoppingAppData
{
    public class DataContext : DbContext
    {
        private readonly string dbConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\ShoppingApp_Database.mdf; Integrated Security = True";
        public DataContext() : base(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " +
                                    Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + 
                                    @"\ShoppingApp_Database.mdf; Integrated Security = True")
        {
            if (!Database.Exists("dbo"))
            {
                Database.SetInitializer(new DropCreateDatabaseAlways<DataContext>());
            }
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
#pragma warning restore CS8618, CS8602 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
