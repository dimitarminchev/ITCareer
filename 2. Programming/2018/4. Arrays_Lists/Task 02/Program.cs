using System;

namespace Task_02
{
/* 2. Най-често срещано число
Напишете програма, която намира най-често срещаното число в дадена последователност.
- Числата ще са в интервала [0 ... 65535].
- В случай, че има няколко най-често срещани числа, изведете най-лявото от тях.
*/
    class Program
    {
        // Решение: Димитър Минчев
        static void Main(string[] args)
        {
            int n = 0; // Инденкс на масива
            int[] num = new int[100];  // Масив със 100 елемента           
            var line = Console.ReadLine(); // Ред от конзолата
            var splitted = line.Split(' '); // Цепим реда на съставящи го

            // Формиране на целочислен масив
            foreach (var item in splitted)
                num[n++] = int.Parse(item);

            // Брояч на срещанията
            int[] counter = new int[65535];

            // Обхождане на масива за намиране на броя на срещанията
            for (int i = 0; i < n; i++)  counter[num[i]]++;

            // Намираме броя на срещанията на числата в масива
            int max = -1000, maxi = 0;
            for (int j = 0; j < 65535; j++)
                if (counter[j] > max)
                {
                    max = counter[j];
                    maxi = j;
                }

            // Отпечаваме числото с най-много срещания в първия масив
            Console.WriteLine(maxi); 
        }
    }
}
