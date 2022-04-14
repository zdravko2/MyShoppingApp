namespace ShoppingAppData.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShoppingAppData.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShoppingAppData.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            DataContext dataContext = new DataContext();

            dataContext.Categories.AddOrUpdate(new Models.Category()
            {
                Id = 0,
                Title = "Uncategorized",
                Thumbnail = File.ReadAllBytes(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\icons8-category-64.png")
            });

            dataContext.Users.AddOrUpdate(new Models.User()
            {
                Id = 0,
                Username = "admin",
                Password = "admin",
                RoleId = 1
            });

            dataContext.SaveChanges();
        }
    }
}
