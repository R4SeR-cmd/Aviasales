using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviaSales.Models.Planes;

namespace AviaSales.Forms
{
    public partial class AddPlane : Form
    {
        public AddPlane()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (numeric_ID.Value <= 0 || string.IsNullOrEmpty(tb_name.Text))
            {
                MessageBox.Show("Invalid id or name");
                return;
            }

            if(Program.AviaSales.Planes.Any(p => p.Id == numeric_ID.Value))
            {
                MessageBox.Show("Id exist");
                return;
            }

            Plane plane = new Plane((int) numeric_ID.Value, tb_name.Text);
            Program.AviaSales.Planes.Add(plane);
            MessageBox.Show("Plane added");

        }
    }
}
