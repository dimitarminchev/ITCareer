using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Cars
{
    public interface ICar
    {
        string Model { get; }
        string Color { get; }
        string Start();
        string Stop();

    }
}
