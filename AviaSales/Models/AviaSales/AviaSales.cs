using AviaSales.Models.Users;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AviaSales.Models.AviaSales
{   
    public class AviaSales
    {
        [JsonProperty("Users")]
        public List<User> Users { get; set; }
        [JsonProperty("Planes")]
        public List<Planes.Plane> Planes { get; set; }
        
        public AviaSales()
        {
            Users = new List<User>();
            Planes = new List<Planes.Plane>();
        }
    }
}
