using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tech_Share_Laptop_Distribution.BL;
using Tech_Share_Laptop_Distribution.DL;

namespace Tech_Share_Laptop_Distribution
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EmployeeDL.LoadFromCSV();
            StockDL.LoadDataFromFile();
            ComplaintsDL.LoadFromComplainCSV();
            OrderDL.getFromFileOrder();
            OrderDL.getFromFileCompletedOrder();
            RiderDL.LoadFromCSV();

            string[] names = { "Admin", "Employee", "Rider" };
            string[] emails = { "admin@gmail.com", "employee@gmail.com", "rider@gmail.com" };
            string[] pwd = { "Abc#%123", "Abc#%123", "Abc#%123" };

            for (int i = 0; i < 3; i++)
            {
                CredientialsBL obj = new CredientialsBL(emails[i], pwd[i], names[i]);
                CredientialsDL.CredientialsList1.Add(obj);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn());

        }
    }
}
