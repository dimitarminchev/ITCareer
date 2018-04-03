using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    /// <summary>
    /// Зарче
    /// </summary>
    class Dice
    {
        // Брой страни 
        private int sides;

        // Конструктор
        public Dice(int number = 6)
        {
            sides = number;
        }

        // Хвърляне
        public int Roll()
        {
            int seed = new DateTime().Millisecond;
            Random rand = new Random(seed);
            return rand.Next(1, sides);
        }           
    }
}
