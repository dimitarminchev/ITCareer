using System;

namespace App1
{
    class Program
    {
        // Главен метод
        static void Main(string[] args)
        {
            // Създавам обект инстанция на клас
            Dice dice = new Dice(6);

            // Хвърляме зара
            Console.WriteLine("Dice Roll = {0}", dice.Roll());
        }
    }
}
