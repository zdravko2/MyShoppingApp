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

            Application.Run(new FormLogin());
            //Application.Run(new FormApp(new User() { Username = "User", Password = "asdasd", RoleId = 1 }));
        }
    }
}