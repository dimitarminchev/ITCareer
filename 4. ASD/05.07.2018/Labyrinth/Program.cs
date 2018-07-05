using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    class Program
    {
        // Намиране на път в лабиринт
        static void Main(string[] args)
        {
            Labyrinth.lab = Labyrinth.ReadLab();
            Labyrinth.FindPaths(0, 0, 'S');
        }
    }
}
