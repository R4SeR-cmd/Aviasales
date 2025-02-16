using System.IO;
using System.Text;
using AviaSales.Models.Users;
using Newtonsoft.Json;

namespace AviaSales.Services
{
    public static class AviaSalesJsonService
    {

        private static readonly JsonSerializerSettings _settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All
        };
        public static void SaveAviaSales(Models.AviaSales.AviaSales aviaSales)
        {
            string json = JsonConvert.SerializeObject(aviaSales, _settings);

            using (Stream stream = new FileStream("aviaSales.json", FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.Write(json);
                }
            }
        }

        public static Models.AviaSales.AviaSales LoadAviaSales()
        {
            string result = string.Empty;
            if (File.Exists("aviaSales.json"))
            {
                using (Stream stream = new FileStream("aviaSales.json", FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                    {
                        while (!reader.EndOfStream)
                        {
                            result += reader.ReadLine() + "\n";
                        }
                    }
                }
            }

            if (!string.IsNullOrEmpty(result))
            {
                return JsonConvert.DeserializeObject<Models.AviaSales.AviaSales>(result, _settings);
            }

            var aviaSales = new Models.AviaSales.AviaSales();
            aviaSales.Users.Add(new Admin("Rostyslav", "Vaso", 19, "rostyk", "1234"));
            return aviaSales;
        }
    }

}
