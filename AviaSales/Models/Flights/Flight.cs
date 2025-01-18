using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaSales.Models.Flights
{
    public class Flight
    {
        public DateTime DepartureDate { get; set; }
        public DateTime DateOfArrival { get; set; }
        public List<Tickets.Ticket> Ticket { get; set; }
        public string DepartureCity { get; set; }
        public string ArrivedCity { get; set; }

        public Flight(DateTime departureDate, DateTime dateOfArrival, string departureCity, string arrivedCity)
        {
            Ticket = new List<Tickets.Ticket>();
            DateOfArrival = dateOfArrival;
            DepartureDate = departureDate;
            DepartureCity = departureCity;
            ArrivedCity = arrivedCity;
        }

    }
}
