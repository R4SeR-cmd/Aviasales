using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaSales.Models.AviaSales
{
    public class AviaSales
    { 
        public List<Users.User> Users { get; set; }
        public List<Planes.Plane> Planes { get; set; }

        public AviaSales()
        {
            Users = new List<Users.User>();
            Planes = new List<Planes.Plane>();
        }
    }
}
