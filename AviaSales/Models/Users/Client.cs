using System.Collections.Generic;
using AviaSales.Models.Tickets;
using Newtonsoft.Json;

namespace AviaSales.Models.Users
{
    public class Client : User
    {
        [JsonProperty("Balance")]
        public decimal Balance { get; set; }
        [JsonProperty("Tickets")]
        public List<Ticket> Tickets { get; set; }
        public Client(string name, string surname, int age, string login, string password) : base(name, surname, age, login, password)
        {
            Tickets = new List<Ticket>();
            Balance = 0;
        }
    }
}
