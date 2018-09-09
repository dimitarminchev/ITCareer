using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _83
{
    class DivisionStrategy : IStrategy
    {
        public int Calculate(int first, int second)
        {
            return first / second;
        }
    }
}
