using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();

            // хвърляме зара 100 пъти
            for (int i = 0; i < 100; i++)
            {
                dice.Roll();
            }

            // Какъв е броя на срещанията на всяко число след 1000 хвърляния
            dice.RollFequency();
        }
    }
}
