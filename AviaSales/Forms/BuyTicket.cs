using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviaSales.Models.Users;

namespace AviaSales.Forms
{
    
    public partial class BuyTicket : Form
    {
        private Client _client;
        public BuyTicket(Client client)
        {
            InitializeComponent();
            _client = client;

            foreach (var plane in Program.AviaSales.Planes)
            {
                foreach (var flight in plane.Flights)
                {
                    if (flight.DepartureDate > DateTime.Now)
                    {
                        listBox1.Items.Add(flight);
                    }
                }
            }
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Choose ticket!");
                return;
            }

            var chooseTicket = new TicketsFiltrationForm(listBox1.SelectedItem, _client);
            chooseTicket.ShowDialog();
        }
    }
}
