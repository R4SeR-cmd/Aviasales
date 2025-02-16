using System;
using System.Linq;
using System.Windows.Forms;
using AviaSales.Models.Users;

namespace AviaSales.Forms
{
    public partial class CancelMyTicket : Form
    {
        private Client _client;
        public CancelMyTicket(Client client)
        {
            InitializeComponent();
            _client = client;


            var futureFlights = Program.AviaSales.Planes
                .SelectMany(p => p.Flights)
                .Where(f => f.DepartureDate > DateTime.Now && 
                                    f.Ticket.Any(t => _client.Tickets.Any(ct => ct.Id == t.Id))).ToList();

            listBox1.Items.AddRange(futureFlights.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Not selected ticket!");
                return;
            }

            _client.Tickets.Remove(_client.Tickets[listBox1.SelectedIndex]);
            MessageBox.Show("Successful delete");
        }
    }
}
