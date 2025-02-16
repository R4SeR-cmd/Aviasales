using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviaSales.Models.Flights;

namespace AviaSales.Forms
{
    public partial class EndedFlight : Form
    {
        
        public EndedFlight()
        {
            InitializeComponent();
            AddEndedFlight();
        }


        private void AddEndedFlight()
        {
            foreach (var plane in Program.AviaSales.Planes)
            {
               var flights = plane.Flights.Where(f => f.DateOfArrival < DateTime.Now);

               if (flights.Count() > 0)
               {
                   foreach (var f in flights)
                   {
                       listBox1.Items.Add(f);
                   }
               }
            }
        }
        
    }
}
