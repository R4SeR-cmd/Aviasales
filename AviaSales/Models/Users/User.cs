using Newtonsoft.Json;

namespace AviaSales.Models.Users
{
    public abstract  class User
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Surname")]
        public string Surname { get; set; }
        [JsonProperty("Age")]
        public int Age { get; set; }
        [JsonProperty("Login")]
        public string Login { get; set; }
        [JsonProperty("Password")]
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
