using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _637
{
    using System;
    using Contracts;
    using _637.Models.Units;
    internal class Horseman : Unit
    {
        private const int DefaultHealth = 50;
        private const int DefaultDamage = 10;

        public Horseman()
            : base(DefaultHealth, DefaultDamage)
        {

        }
    }
    }
