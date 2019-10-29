using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _638
{
    using System;
    using Contracts;
    using _638.Models.Units;
    internal class Gunner : Unit
    {
        private const int DefaultHealth = 20;
        private const int DefaultDamage = 20;

        public Gunner()
            : base(DefaultHealth, DefaultDamage)
        {

        }
    }
}
