using ShoppingAppData;
using ShoppingAppData.Models;
using ShoppingApp.ViewInterfaces;

namespace ShoppingApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            //Creating admin user
            DataContext _dataContext = new DataContext();
            if (_dataContext.Users.FirstOrDefault(u => u.Id == 1) == null)
            {
                _dataContext.Users.Add(new User()
                {
                    Id = 1,
                    Username = "admin",
                    Password = "admin",
                    RoleId = 1
                });
                _dataContext.SaveChanges();
            }

            Application.Run(new FormLogin());
        }
    }
}