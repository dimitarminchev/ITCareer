using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ChuckNorris_UWP
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

}
