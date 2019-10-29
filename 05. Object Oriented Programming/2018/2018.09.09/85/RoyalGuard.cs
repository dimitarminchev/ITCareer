using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _85
{
    public class RoyalGuard 
    {
        // life
        private int life = 3;
        public int Life
        {
            get { return this.life;  }
        }

        // name
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
            this.life--;
            Helper.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}
