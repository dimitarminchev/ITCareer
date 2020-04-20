using System.Collections.Generic;

namespace _2.ChuckNorris
{
    /// <summary>
    /// Виц
    /// </summary>
    public class Joke
    {
        public string type { get; set; }
        public Value value { get; set; }
    }

    /// <summary>
    /// Съдържание
    /// </summary>
    public class Value
    {
        public int id { get; set; }
        public string joke { get; set; }
        public List<object> categories { get; set; }
    }
}
