using System;
using System.Linq;
using System.Windows.Forms;
using AviaSales.Enums;
using AviaSales.Models.Flights;
using AviaSales.Models.Users;

namespace AviaSales.Forms
{
    public partial class TicketsFiltrationForm : Form
    {
        private Flight _flight;
        private Client _client;
        public TicketsFiltrationForm(object listBox1SelectedItem, Client client)
        {
            _client = client;
            _flight = (Flight) listBox1SelectedItem;
            InitializeComponent();
            UpdateTicketInfo();
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            int ecoCount = (int)numeric_eco.Value;
            int businessCount = (int)numeric_business.Value;
            int firstClassCount = (int)numeric_1stClass.Value;

            decimal totalCost = 0;

            totalCost += ecoCount * (_flight.Ticket.FirstOrDefault(t => t.Type == TypeTicket.Eco)?.Price ?? 0);
            totalCost += businessCount * (_flight.Ticket.FirstOrDefault(t => t.Type == TypeTicket.Business)?.Price ?? 0);
            totalCost += firstClassCount * (_flight.Ticket.FirstOrDefault(t => t.Type == TypeTicket.FirstClass)?.Price ?? 0);

           
            if (_client.Balance < totalCost)
            {
                MessageBox.Show("You do not have enough money to complete this purchase!", "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            _client.Balance -= totalCost;

            if (ecoCount > 0)
            {
                var ecoTickets = _flight.Ticket.Where(t => t.Type == TypeTicket.Eco).Take(ecoCount).ToList();
                if (ecoTickets.Count == ecoCount)
                {
                    _client.Tickets.AddRange(ecoTickets);
                    _flight.Ticket.RemoveAll(t => ecoTickets.Contains(t));
                    MessageBox.Show($"You have successfully purchased {ecoCount} economy class tickets!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Not enough economy class tickets available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (businessCount > 0)
            {
                var businessTickets = _flight.Ticket.Where(t => t.Type == TypeTicket.Business).Take(businessCount).ToList();
                if (businessTickets.Count == businessCount)
                {
                    _client.Tickets.AddRange(businessTickets);
                    _flight.Ticket.RemoveAll(t => businessTickets.Contains(t));
                    MessageBox.Show($"You have successfully purchased {businessCount} business class tickets!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Not enough business class tickets available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (firstClassCount > 0)
            {
                var firstClassTickets = _flight.Ticket.Where(t => t.Type == TypeTicket.FirstClass).Take(firstClassCount).ToList();
                if (firstClassTickets.Count == firstClassCount)
                {
                    _client.Tickets.AddRange(firstClassTickets);
                    _flight.Ticket.RemoveAll(t => firstClassTickets.Contains(t));
                    MessageBox.Show($"You have successfully purchased {firstClassCount} first-class tickets!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Not enough first-class tickets available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           
            UpdateTicketInfo();
           
        }

       
        private void UpdateTicketInfo()
        {
            lb_count1stClass.Text = _flight.Ticket.Count(t => t.Type == TypeTicket.FirstClass).ToString();
            lb_countBusiness.Text = _flight.Ticket.Count(t => t.Type == TypeTicket.Business).ToString();
            lb_countEco.Text = _flight.Ticket.Count(t => t.Type == TypeTicket.Eco).ToString();

            lb_price1stClass.Text = _flight.Ticket
                .FirstOrDefault(t => t.Type == TypeTicket.FirstClass)?.Price.ToString() ?? "N/A";
            lb_priceBusiness.Text = _flight.Ticket
                .FirstOrDefault(t => t.Type == TypeTicket.Business)?.Price.ToString() ?? "N/A";
            lb_priceEco.Text = _flight.Ticket
                .FirstOrDefault(t => t.Type == TypeTicket.Eco)?.Price.ToString() ?? "N/A";
        }


    }
}
