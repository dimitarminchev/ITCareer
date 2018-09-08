using _03BarracksFactory.Models.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03BarracksFactory.Models.Units
{
    class Gunner:Unit
    {
        private const int DefaultHealth = 20;
        private const int Attack = 20;
        public Gunner() : base(DefaultHealth, Attack)
        {
        }
    }
}
