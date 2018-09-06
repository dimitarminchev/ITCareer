using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _481
{
    public class Robot : IIdentifiable
    {
        public string model { get; private set; }
        public string id { get; private set; }

        public Robot(string model, string id)
        {
            this.model = model;
            this.id = id;
        }
    }
}
