using System;

namespace _4._Jobs
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4х4 = Цена за извършване на работа на работниците
            int [,] jobs =
            {
                { 9,2,7,8 },
                { 6,4,3,7 },
                { 5,8,1,8 },
                { 7,6,9,4 }
            };
            // Пермутации на елементите
            for (int j1 = 0; j1 < 4; j1++)
            {
                for (int w1 = 0; w1 < 4; w1++)
                {
                    Console.Write("{0} ", jobs[w1,j2]);
                }
                Console.WriteLine();
            }
        }
    }
}
