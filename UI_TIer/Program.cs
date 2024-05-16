using CafeShopManagement;
using View;

namespace UI_TIer
{
    public static class Program
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
            //Application.Run(new ProductForm());
            //Application.Run(new CustomerForm());
            Application.Run(new loginForm());
            //Application.Run(new OrderForm());
            //Application.Run(new MainMenu());

        }
    }
}