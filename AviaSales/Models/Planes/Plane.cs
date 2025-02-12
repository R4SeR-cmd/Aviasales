using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviaSales.Models.Flights;

namespace AviaSales.Models.Planes
{
    public class Plane
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Flight> Flights { get; set; }
        
        public Plane(int id, string name)
        {
            Id = id;
            Name = name;
            Flights = new List<Flight>();
        }
    }
}
