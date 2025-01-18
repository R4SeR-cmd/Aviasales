using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviaSales.Forms;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
