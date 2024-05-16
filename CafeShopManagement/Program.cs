
namespace CafeShopManagement
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            ApplicationConfiguration.Initialize();
            //Application.Run(new loginForm());
            //Application.Run(new registerForm());
            //Application.Run(new AdminMainMenu());
            //Application.Run(new UserDataForm());
            //Application.Run(new createUserForm());
            //Application.Run(new UpdateUserForm());
           
            Application.Run(new ProductForm());
        }
    }
}