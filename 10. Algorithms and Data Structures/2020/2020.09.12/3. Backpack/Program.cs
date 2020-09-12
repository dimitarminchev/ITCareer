using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Backpack
{
    class Program 
    {
        static void Main(string[] args) 
        {
            List<int> w = new List<int> { 7, 3, 4, 5 }; // Тегла на предметите в килограми
            List<int> v = new List<int> { 42, 12, 40, 25 }; // Цени на предметите в килограми

            int maxCapacity = 10;  // Максимален капацитет на раницата
            int maxValue = 0; // Максимална сума

            // Намиране комбинациите на тегла и цени
            var weights = GetCombination(w);
            var prices =  GetCombination(v);
            int vi = 0;

            // Обхождаме получените комбинации от тегла
            foreach (var item in weights)
            {
                // Суми на тегла и цени
                int sumPrices = prices[vi].Sum();
                int sumWeights = item.Sum();
                vi++;

                // Отпечатваме
                Console.Write(string.Join(" + ", item));
                Console.WriteLine(" = {0} kg / {1}$", sumWeights, sumPrices);

                // Получаване на максималната сума
                if (sumWeights <= maxCapacity && sumPrices > maxValue)
                {
                    maxValue = sumPrices;
                }
            }

            // Отпечаване на максималната сума
            Console.WriteLine("Maximum value: {0}$", maxValue);
        }

        // Матод за намиране на комбинациите на елементите 
        static List<List<int>> GetCombination(List<int> list)
        {
            var resultList = new List<List<int>>();
            double count = Math.Pow(2, list.Count);
            for (int i = 1; i <= count - 1; i++)
            {
                var nextList = new List<int>();
                string str = Convert.ToString(i, 2).PadLeft(list.Count, '0');
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == '1')
                    {
                        nextList.Add(list[j]);
                    }
                }
                resultList.Add(nextList);
            }
            return resultList;
        }
    }
}
