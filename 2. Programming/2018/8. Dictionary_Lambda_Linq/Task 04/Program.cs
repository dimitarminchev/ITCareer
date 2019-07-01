using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
/* 4. Супермаркет
Напишете програма, която пази информация за продукти и техните цени. Всеки продукт си има име, цена и количество. Ако продъктът не съществува в базата данни, той се добавя със стартово количество.
Ако получите продукт, който вече съществува, то ще увеличите неговото количество и ако цената е различна, ще замените старата с новата цена.
Ще получите име, цена и количество за всеки продукт на нов ред. Накрая ще стои команда "stocked". При нейното срещане, изведете всичките артикули с техните име, цена, наличност и обща цена на вски продукти с това име. Когато изведете всички продукти, изведете и общата цена на всички артикули.
Решение: Живко Колев
*/
    class Program
    {
        static void Main(string[] args)
        {
            var Market = new Dictionary<string, Tuple<float, int>>();
            // Въвеждане на данни в речника
            while (true)
            {
                var line = Console.ReadLine().Split(' ');
                if (line[0] == "stocked") break;

                float key = float.Parse(line[1]);
                int value = int.Parse(line[2]);
                Market.Add(line[0], new Tuple<float, int>(key, value));
            }
            // Извеждане на резултата
            double total = 0;
            foreach (var pair in Market)
            {
                float sum = pair.Value.Item1 * pair.Value.Item2;
                Console.WriteLine("{0}: ${1:f2} * {2} = ${3:f2}",
                                   pair.Key, pair.Value.Item1, pair.Value.Item2, sum);
                total += sum;
            }
            Console.WriteLine(new String('-', 30));
            Console.WriteLine("Grand Total: ${0:f2}", total);
        }
    }
}
