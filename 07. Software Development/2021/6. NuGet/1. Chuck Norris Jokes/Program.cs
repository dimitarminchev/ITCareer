using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _1._Chuck_Norris_Jokes
{
    /// <summary>
    /// Chuck Norris Jokes main program class.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Get Joke method.
        /// </summary>
        /// <returns>JSON format</returns>
        private static async Task<string> GetJoke()
        {
            HttpClient client = new HttpClient();
            return await client.GetStringAsync("https://api.chucknorris.io/jokes/random");
        }

        /// <summary>
        /// Chuck Norris Jokes main program method.
        /// </summary>
        static void Main(string[] args)
        {
            // Get new random Chuck Norris joke as JSON
            string json1 = GetJoke().Result;

            // Deserialize JSON string to C# object
            Joke joke = JsonConvert.DeserializeObject<Joke>(json1);
            Console.WriteLine("Joke: {0}", joke.value);
            Console.WriteLine("Created: {0}", joke.created_at);
            Console.WriteLine("Updated: {0}", joke.updated_at);
            Console.WriteLine("Link: {0}", joke.url);

            // Serialize C# object to JSON string
            string json2 = JsonConvert.SerializeObject(joke);
            Console.WriteLine("\n\nJSON:\n{0}", json2);
        }
        
    }
}
