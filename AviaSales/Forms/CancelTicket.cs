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
    public partial class CancelTicket : Form
    {
        private Client _client;
        public CancelTicket()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            var users = Program.AviaSales.Users.Where(u => u.Login == tb_customer.Text);

            if (users.Count() == 0)
            {
                MessageBox.Show("Client not found");
                return;
            }

            _client = (Client) users.First();

            foreach (var ticket in _client.Tickets)
            {
                listBox1.Items.Add(ticket);
            }
            
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                _client.Tickets.RemoveAt(listBox1.SelectedIndex);
                MessageBox.Show("Succeful");
            }
            
        }
    }
}
