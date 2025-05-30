using SupermarketManagmentSystem_SMS;

namespace Supermarket_Managment_System_SMS
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
            //Application.Run(new MainForm());
            //Application.Run(new Products());
            //Application.Run(new Users());
            Application.Run(new Reports());
            //Application.Run(new Categories());
        }
    }
}