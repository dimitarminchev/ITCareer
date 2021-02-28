using System.Collections.Generic;

namespace _1._Chuck_Norris_Jokes
{
    /// <summary>
    /// Chuck Norris Joke class.
    /// </summary>
    public class Joke
    {
        /// <summary>
        /// Jokes categories;
        /// </summary>
        public List<object> categories { get; set; }

        /// <summary>
        /// Joke created date and time.
        /// </summary>
        public string created_at { get; set; }

        /// <summary>
        /// Link to the Chuck Norris icon. 
        /// </summary>
        public string icon_url { get; set; }

        /// <summary>
        /// Identificator of the Joke.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Jocke last update date and time.
        /// </summary>
        public string updated_at { get; set; }

        /// <summary>
        /// Link to the Joke.
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// The joke itself.
        /// </summary>
        public string value { get; set; }
    }
}
