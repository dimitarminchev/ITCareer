using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _85
{
    public class Footman 
    {
        // life
        private int life = 2;
        public int Life
        {
            get { return this.life; }
        }

        // property
        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // constructor
        public Footman(string name)
        {
            this.Name = name;
        }

        // event
        public void KingIsUnderAttack(object sender, EventArgs e)
        {
            this.life--;
            Helper.WriteLine($"Footman {this.Name} is panicking!");
        }
    }
}
