using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _483
{
    interface IBuyer
    {
        int food { get; }
        string name { get; }
        int age { get; }
        void BuyFood();
    }
}
