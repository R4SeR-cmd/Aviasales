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
    public partial class TopUpBalance : Form
    {
        private Client _client;
        public TopUpBalance(Client client)
        {
            InitializeComponent();
            _client = client;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                _client.Balance += numericUpDown1.Value;
                MessageBox.Show($"Balance top up on {numericUpDown1.Value} $");
            }
        }
    }
}
