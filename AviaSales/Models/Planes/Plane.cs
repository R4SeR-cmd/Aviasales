using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviaSales.Models.Flights;
using Newtonsoft.Json;

namespace AviaSales.Models.Planes
{
    public class Plane
    {
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Flights")]
        public List<Flight> Flights { get; set; }
        
        public Plane(int id, string name)
        {
            Id = id;
            Name = name;
            Flights = new List<Flight>();
        }
    }
}
