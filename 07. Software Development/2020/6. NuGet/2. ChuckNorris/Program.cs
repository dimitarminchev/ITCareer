using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace _2.ChuckNorris
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 1. Изтегляне на виц за Чък Норис
            var client = new HttpClient();
            var json = client.GetStringAsync("http://api.icndb.com/jokes/random").Result;
            Console.WriteLine(json);
            Console.WriteLine(new string('-', 50));

            // 2. Десериализиране на виц за Чък Норис
            var obj = JsonConvert.DeserializeObject<Joke>(json);
            Console.WriteLine(obj.value.joke);
        }
    }
}
