using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaSales.Models.Users
{
    public class Admin : User
    {
        public Admin(string name, string surname, int age, string login, string password) : base(name, surname, age, login, password)
        {
        }
    }
}
