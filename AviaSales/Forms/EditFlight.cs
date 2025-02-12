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
using AviaSales.Models.Planes;

namespace AviaSales.Forms
{
    public partial class EditFlight : Form
    {
        private Plane _plane;
        public EditFlight()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            var plane = Program.AviaSales.Planes.FirstOrDefault(p => p.Id == numericUpDown1.Value);
            
            if (plane == null)
            {
                MessageBox.Show("Invalid id");
                return;

            }

            _plane = plane;

            foreach (var p in _plane.Flights)
            {
                listBox1.Items.Add(p);
            }

        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < -1)
            {
                return;
            }

            var flight = _plane.Flights.FirstOrDefault(f => f.Id == listBox1.SelectedIndex);

            var editFlightNestedForm = new EditFlightNestedForm(flight, _plane);
            editFlightNestedForm.ShowDialog();
        }
    }
}
