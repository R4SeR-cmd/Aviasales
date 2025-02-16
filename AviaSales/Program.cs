using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviaSales.Forms;
using AviaSales.Models.Users;
using AviaSales.Services;

namespace AviaSales
{
    public static class Program
    {
        public static Models.AviaSales.AviaSales AviaSales = AviaSalesJsonService.LoadAviaSales();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginForm());
            }
            finally
            {
                AviaSalesJsonService.SaveAviaSales(AviaSales);
            }
        }
    }
}
