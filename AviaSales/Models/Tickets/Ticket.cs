using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviaSales.Enums;

namespace AviaSales.Models.Tickets
{
    public class Ticket
    {
        public int Id { get; set; }
        public TypeTicket Type { get; set; }
        public int Price { get; set; }

        public Ticket(int price, int id, TypeTicket type)
        {
            Id = id;
            Type = type;
            Price = price;
        }
    }
}
