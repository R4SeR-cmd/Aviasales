using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaSales.Models.Flights
{
    public class Flight
    {
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("Departure date")]
        public DateTime DepartureDate { get; set; }
        [JsonProperty("Date of arrival")]
        public DateTime DateOfArrival { get; set; }
        [JsonProperty("Ticket")]
        public List<Tickets.Ticket> Ticket { get; set; }
        [JsonProperty("Departure City")]
        public string DepartureCity { get; set; }
        [JsonProperty("Arrived City")]
        public string ArrivedCity { get; set; }

        public Flight(int id, DateTime departureDate, DateTime dateOfArrival, string departureCity, string arrivedCity)
        {
            Id = id;
            Ticket = new List<Tickets.Ticket>();
            DateOfArrival = dateOfArrival;
            DepartureDate = departureDate;
            DepartureCity = departureCity;
            ArrivedCity = arrivedCity;
        }

        public override string ToString() =>  $"{Id}: {DepartureCity} → {ArrivedCity}, Departure: {DepartureDate:yyyy-MM-dd HH:mm}, Arrival: {DateOfArrival:yyyy-MM-dd HH:mm}";
    }
}
