using Newtonsoft.Json;
/// <summary>
/// Task "Chuck Norris Jokes" namespace.
/// </summary>
namespace ChuckNorrisJokes
{
    /// <summary>
    /// Task "Chuck Norris Jokes" main program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Task "Chuck Norris Jokes" main program method.
        /// </summary>
        static void Main(string[] args)
        {
            // Step 1. Get Chuck Norris Joke from Internet
            string json = GetJoke().Result;

            // Step 2. Deserilize JSON to Object
            Joke joke = JsonConvert.DeserializeObject<Joke>(json);

            // Step 3. Print Joke
            Console.WriteLine(joke.value);
        }

        /// <summary>
        /// Get New Chuck Norris Joke from Internet
        /// </summary>
        /// <returns>json</returns>
        private static async Task<string> GetJoke()
        {
            string url = "https://api.chucknorris.io/jokes/random";
            HttpClient client = new HttpClient();
            return await client.GetStringAsync(url);
        }
    }
}