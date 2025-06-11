using SupermarketManagmentSystem_SMS;
using Microsoft.Extensions.DependencyInjection;
using SupermarketManagmentSystem_SMS.Data;

namespace SupermarketManagmentSystem_SMS
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
            Application.EnableVisualStyles(); // Replace ApplicationConfiguration.Initialize()  
            Application.SetCompatibleTextRenderingDefault(false);

           
            //Application.Run(new CashierMainForm()); 
            //Application.Run(new Reports());
            Application.Run(new LoginForm());
            //Application.Run(new MainForm());
            //Application.Run(new AddUser());
            //Application.Run(new CashierDashboardForm());
            //Application.Run(new BillingForm());

        }
    }
}