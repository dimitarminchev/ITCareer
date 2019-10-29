using System;

namespace Task_04
{
/* 4. Преобразуване на масив в число
Напишете програма, която въвежда масив от цели числа и г пребразува чрез сумиране  на съседни двойки елементи, докато се получи едно цяло число. Например, ако имаме 3 елемента {2,10,3},  то събираме първите два и вторите два елемента и получаваме {2+10, 10+3} = {12, 13}, после събираме всички съседни елементи и получаваме obtain {12+13} = {25}.
*/
    class Program
    {
        // Решение: Димитър Минчев
        static void Main(string[] args)
        {
            // Въвеждане на масив
            int n = 0; 
            int[] nums = new int[100];       
            var line = Console.ReadLine().Split(' '); 
            foreach (var item in line)nums[n++] = int.Parse(item);

            // Компресиран масив
            int[] condensed = new int[100];
            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                    // Console.WriteLine("> " + condensed[i]);
                }
                nums = condensed;
                n--;
            } while (n != 1);

            // Резултат
            Console.WriteLine(condensed[n-1]);
       
        }
    }
}
