using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaSales.Models.Users
{
    public abstract  class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        protected User(string name, string surname, int age, string login, string password)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Login = login;
            Password = password;
        }
    }

}
