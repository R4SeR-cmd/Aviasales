using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaSales.Models.Users
{
    public class Client : User
    {
        public decimal Balance { get; set; }
        public Client(string name, string surname, int age, string login, string password) : base(name, surname, age, login, password)
        {
            Balance = 0;
        }
    }
}
