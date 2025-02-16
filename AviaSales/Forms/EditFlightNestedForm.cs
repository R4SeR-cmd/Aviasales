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
    
    public partial class EditFlightNestedForm : Form
    {
        private Flight _flight;
        private Plane _plane;
        public EditFlightNestedForm(Flight flight, Plane plane)
        {
            InitializeComponent();
            _flight = flight;
            numeric_flight.Value = _flight.Id;
            tb_from.Text = _flight.DepartureCity;
            tb_destinati.Text = _flight.ArrivedCity;
            dateTimePicker_date.Value = _flight.DepartureDate;
            dateTimePicker_arriving.Value = _flight.DateOfArrival;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if ( numeric_flight.Value <= 0 || string.IsNullOrEmpty(tb_from.Text) ||
                 string.IsNullOrEmpty(tb_destinati.Text))
            {
                MessageBox.Show("Invalid data");
                return;
            }

            if (dateTimePicker_arriving.Value <= dateTimePicker_date.Value)
            {
                MessageBox.Show("Invalid time for flight");
                return;
            }

            if (_flight.Id != numeric_flight.Value)
            {
                if (_plane.Flights.Any(f => f.Id == numeric_flight.Value))
                {
                    MessageBox.Show("Flight id exist");
                    return;
                }

                _flight.Id = (int) numeric_flight.Value;
            }
            
            _flight.DepartureCity = tb_from.Text;
            _flight.ArrivedCity = tb_destinati.Text;
            _flight.DepartureDate = dateTimePicker_date.Value;
            _flight.DateOfArrival = dateTimePicker_arriving.Value;

            MessageBox.Show("Сhanges are successful");
        }
    }
}
