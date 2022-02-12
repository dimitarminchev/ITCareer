using System;

/// <summary>
/// Chuck Noris NAmespace
/// </summary>
namespace ChuckNorris 
{
    // Referenct to NuGet Package: Newtonsoft.Json 
    using Newtonsoft.Json;

    /// <summary>
    /// Chuck Noris Main Program Class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Jet Chuck Norris Joke
        /// </summary>
        /// <returns></returns>
        public static async Task<string> GetJoke()
        {
            var client = new HttpClient();
            var response = await client.GetStringAsync("https://api.chucknorris.io/jokes/random");
            return response;
        }

        /// <summary>
        /// Chuck Norris Main Program Method
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            // 1. Get Chuck Noris Joke as JSON
            Console.WriteLine("1. Get Chuck Noris Joke as JSON:");
            var joke = GetJoke().Result;
            Console.WriteLine(joke);

            // Empty Line
            Console.WriteLine();


            // 2. Deserialize JSON to Object
            Console.WriteLine("2. Deserialize JSON to Object:");
            var obj = JsonConvert.DeserializeObject<Root>(joke);
            Console.WriteLine(obj.value);
            Console.WriteLine("Date: {0}", obj.created_at);

            // Empty Line
            Console.WriteLine();

            // 3. Serialize Object to JSON
            Console.WriteLine("3. Serialize Object to JSON");
            var json  = JsonConvert.SerializeObject(obj);
            Console.WriteLine(json);
        }
    }
}