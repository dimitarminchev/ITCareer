using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LetterIndex
{
    class Program
    {
        // 2. Индекс на буква
        static void Main(string[] args)
        {
            // Входни данни
            var input = Console.ReadLine();

            // Обработка и извеждане на индекса на всяка буква
            for (int i = 0; i < input.Length; i++)
            Console.WriteLine("{0} -> {1}", input[i], input[i] - 97);
        }
    }
}
