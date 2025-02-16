using AviaSales.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviaSales.Forms
{
    public partial class Your_tickets : Form
    {
        private Client _client;
        public Your_tickets(Client client)
        {
            InitializeComponent();
            _client = client;
           
            var futureFlights = Program.AviaSales.Planes
                .SelectMany(p => p.Flights)
                .Where(f => f.DepartureDate > DateTime.Now &&
                            f.Ticket.Any(t => _client.Tickets.Any(ct => ct.Id == t.Id))).ToList();

            listBox1.Items.AddRange(futureFlights.ToArray());
        }
    }
}
