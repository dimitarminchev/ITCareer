using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
/* 13. Имунна система
Всеки организъм може да бъде нападнат от различни видове вируси. Информация за тях се съхраняват в имунната му система. Ако тя вече е среща вируса, ще го победи по-бързо, отколкото ако го среща за първи път. Имунната система може да изчисли силата на вируса преди да го победи. Това е сумата от кодовете на всички букви в името на вируса, разделена на 3. Имунната система може да изчисли времето, което трябва да се победи даден вирус в секунди. То е равно на силата на вируса умножено по дължината на името на вируса. Когато изчислите времето за побеждаване на вируса, превърнете го в минути и секунди, като не използвате водещи нули.
Решение: Божидар Андонов
*/
    class Program
    {
        static void Main(string[] args)
        {
            int health = int.Parse(Console.ReadLine());
            int originalhealth = health;
            string virus = Console.ReadLine();
            var encountered = new Dictionary<string, int>();
            string previousvirus = string.Empty;
            while (true)
            {
                if (encountered.ContainsKey(virus)) encountered[virus] += 1;
                else encountered[virus] = 1;
                int power = 0;
                foreach (var ch in virus)
                    power += (int)ch;
                power /= 3;
                int time = power * virus.Length;
                if (encountered[virus] > 1 && previousvirus != virus) time /= 3;
                health -= time;
                Console.WriteLine($"Virus {virus}: {power} => {time} seconds");
                if (health <= 0)
                {
                    Console.WriteLine("Immune System Defeated.");
                    break;
                }
                else
                {
                    Console.WriteLine($"{virus} defeated in {time / 60}m {time % 60}s.");
                    Console.WriteLine($"Remaining health: {health}");
                    health = health + (health * 20) / 100;
                    if (health > originalhealth) health = originalhealth;
                }
                previousvirus = virus;
                virus = Console.ReadLine();
                if (virus == "end")
                {
                    Console.WriteLine($"Final Health: {health}");
                    break;
                }
            }
        }
    }
}
