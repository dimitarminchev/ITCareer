using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Dice
{
    class Dice
    {
        // Брой страни на зара
        private int sides;
        private int[] rollFrequency;
        private Random random;

        // Конструктор без параметри
        public Dice() : this(6)
        {
        }

        // Конструктор с параметри
        public Dice(int sides)
        {
            this.sides = sides;
            this.rollFrequency = new int[sides];
            this.random = new Random();
        }

        // Хвърляне на зара
        public void Roll()
        {
            var next = random.Next(1, this.sides + 1);
            this.rollFrequency[next - 1]++;
        }

        // БРой на хвърлянията
        public void RollFequency()
        {
            for (int i = 0; i < this.sides; i++)
            {
                Console.WriteLine("Side {0} = {1} Count", i+1, rollFrequency[i]);
            }
        }
    }

}
