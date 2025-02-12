using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviaSales.Forms;
using AviaSales.Models.Users;

namespace AviaSales
{
    public static class Program
    {
        public static Models.AviaSales.AviaSales AviaSales = new Models.AviaSales.AviaSales ();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Admin admin = new Admin("Rostyslav", "Vaso", 19, "rostyk", "1234");
            Program.AviaSales.Users.Add(admin);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            Application.Run(new LoginForm());

        }
    }
}
