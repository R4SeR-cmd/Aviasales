using System;
using System.Linq;
using System.Windows.Forms;
using AviaSales.Models.Planes;

namespace AviaSales.Forms
{
    public partial class CancelFlight : Form
    {
        private Plane _plane;
        public CancelFlight()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (Program.AviaSales.Planes.Any(p => p.Id == numericUpDown1.Value))
            {
                var plane = Program.AviaSales.Planes.FirstOrDefault(p => p.Id == numericUpDown1.Value);

                _plane = plane;

                foreach (var p in _plane.Flights)
                {
                    listBox1.Items.Add(p);
                }
            }
            else
            {
                MessageBox.Show("Invalid id");
                return;
            }
        }

      

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Choose flight!");
                return;
            }

            var flight = _plane.Flights.FirstOrDefault(f => f.Id == listBox1.SelectedIndex);
            _plane.Flights.Remove(flight);
            listBox1.Items.Remove(flight);
            MessageBox.Show("Remove successful");
        }
    }
}
