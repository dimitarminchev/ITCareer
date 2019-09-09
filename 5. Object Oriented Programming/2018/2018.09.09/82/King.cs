using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _82
{
    public class King
    {
        // property
        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // constructor
        public King(string name)
        {
            this.Name = name;
        }

        // event
        public event EventHandler OnUnderAttack;
        public void UnderAttack(EventArgs e)
        {
            Helper.WriteLine($"King {this.name} is under attack!");
            try
            {
                OnUnderAttack(this, e);
            }
            catch { ;; }
        }
    }
}
