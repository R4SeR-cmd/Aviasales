using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviaSales.Models.Tickets;

namespace AviaSales.Models.Users
{
    public class Client : User
    {
        public decimal Balance { get; set; }
        public List<Ticket> Tickets { get; set; }
        public Client(string name, string surname, int age, string login, string password) : base(name, surname, age, login, password)
        {
            Tickets = new List<Ticket>();
            Balance = 0;
        }
    }
}
