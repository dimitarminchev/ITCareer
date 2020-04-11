using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChuckNorris
{
    public class Value
    {
        public int id { get; set; }
        public string joke { get; set; }
        public List<object> categories { get; set; }
    }

    public class RootObject
    {
        public string type { get; set; }
        public Value value { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            Uri uri = new Uri("http://api.icndb.com/jokes/random");
            String text = client.DownloadString(uri);

            // Deserialize: JSON > OOP
            var json = JsonConvert.DeserializeObject<RootObject>(text);
            Console.WriteLine(json.value.joke);
        }
    }
}
