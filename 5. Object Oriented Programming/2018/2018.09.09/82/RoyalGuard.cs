using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _82
{
    public class RoyalGuard 
    {
        // property
        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // constructor
        public RoyalGuard(string name)
        {
            this.Name = name;
        }

        // event
        public void KingIsUnderAttack(object sender, EventArgs e)
        {
            Helper.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}
