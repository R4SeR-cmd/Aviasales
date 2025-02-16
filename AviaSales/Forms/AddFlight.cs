using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviaSales.Enums;
using AviaSales.Models.Flights;
using AviaSales.Models.Planes;
using AviaSales.Models.Tickets;

namespace AviaSales.Forms
{
    public partial class AddFlight : Form
    {
        public AddFlight()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (numeric_planes.Value <= 0 || numeric_flight.Value <= 0 ||
                string.IsNullOrEmpty(tb_from.Text) || string.IsNullOrEmpty(tb_destinati.Text))
            {
                MessageBox.Show("Invalid data");
                return;
            }

            if (dateTimePicker_arriving.Value <= dateTimePicker_date.Value &&
                dateTimePicker_date.Value < DateTime.Now)
            {
                MessageBox.Show("Invalid time for flight");
                return;
            }

            if (numericU_economyCount.Value + numeric_firstClassCount.Value + numeric_businessCount.Value < 1)
            {
                MessageBox.Show("Min count of tickets can`t be less 1");
                return;
            }


            var planes = Program.AviaSales.Planes.Where(p => p.Id == (int)numeric_planes.Value);

            if (!planes.Any())
            {
                MessageBox.Show("Invalid  plane");
                return;
            }

            Plane plane = planes.First();

            if (plane.Flights.Any(f => f.Id == numeric_flight.Value))
            {
                MessageBox.Show("Flight id already exist");
                return;
            }

            var flight = new Flight((int)numeric_flight.Value, dateTimePicker_date.Value,dateTimePicker_arriving.Value,tb_from.Text,tb_destinati.Text);
            
            
            var enonomyTicket = new Ticket((int) numeric_economyPrice.Value, TypeTicket.Eco);
            for (int i = 0; i < numericU_economyCount.Value; i++)
            {
                flight.Ticket.Add(enonomyTicket);
            }
            var businessTicket = new Ticket((int)numeric_businessPrice.Value, TypeTicket.Business);
            for (int i = 0; i < numeric_businessCount.Value; i++)
            {
                flight.Ticket.Add(businessTicket);
            }

            var firstClassTicket = new Ticket((int)numeric_FirstClassPrice.Value, TypeTicket.FirstClass);
            for (int i = 0; i < numeric_FirstClassPrice.Value; i++)
            {
                flight.Ticket.Add(firstClassTicket);
            }

            plane.Flights.Add(flight);

            MessageBox.Show("successful added flight");



        }
    }
}
