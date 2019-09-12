using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ZeroSum
{
    class Program
    {
        // variations
        public static List<List<bool>> variations = new List<List<bool>>();
        public static List<bool> currentVariation = new List<bool>();
        public static int number;

        static void Variations(int n)
        {
            if (n == number)
            {
                bool[] variationToAdd = new bool[currentVariation.Count];
                currentVariation.CopyTo(variationToAdd, 0);
                variations.Add(variationToAdd.ToList());
                return;
            }
            else
            {
                currentVariation.Add(false);
                Variations(n + 1);
                currentVariation.RemoveAt(n);

                currentVariation.Add(true);
                Variations(n + 1);
                currentVariation.RemoveAt(n);
            }
        }

        static void Main(string[] args)
        {
/* input:
8
1 2 3 4 5 6 7 8
*/
            number = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Generate All Possible Variations of Plus And Minus
            
            Variations(0);

            // Process
            foreach (var candidate in variations)
            {
                int sum = 0;
                int position = 0;
                foreach (var sign in candidate)
                {
                    if (sign) sum += numbers[position];
                    else sum -= numbers[position];
                    position++;
                }
                //Console.Write(string.Join(", ", candidate));
                //Console.WriteLine(" = {0}",sum);
                if (sum == 0)
                {                    
                    for (int i = 0; i < number; i++)
                    {
                        var sign = candidate[i].ToString().Replace("True", "+").Replace("False", "-");
                        Console.Write("{0}{1} ", sign, numbers[i]);                        
                    }
                    Console.WriteLine(" = 0");
                }
            }

        }
    }
}
