using AviaSales.Enums;
using Newtonsoft.Json;
using System;

namespace AviaSales.Models.Tickets
{
    public class Ticket
    {
        [JsonProperty("Type")]
        public TypeTicket Type { get; set; }
        [JsonProperty("Price")]
        public int Price { get; set; }
        [JsonProperty("Id")]
        public int Id;
        public Ticket(int price,  TypeTicket type)
        {
            Random random = new Random();
            Type = type;
            Price = price;
            Id = random.Next(1, 999999);
        }
    }
}
