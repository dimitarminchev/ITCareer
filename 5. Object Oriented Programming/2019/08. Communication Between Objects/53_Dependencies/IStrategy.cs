using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_Dependencies
{
    interface IStrategy
    {
        int Calculate(int first, int second);
    }
}
