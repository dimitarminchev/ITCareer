using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    // 1.2. Problem 3. Подреждане на думи
    class Program
    {
        // O(n) + O(n^2) O(n) ~ O(n^2)
        static void Main(string[] args)
        {
            //  O(n)
            List<string> words = Console.ReadLine().Split().ToList();

            // O(n^2)
            List<string> result = new List<string>(); 
            var minimum = words.First(); 
            for (int m = 0; m < words.Count; m++)
            {
                for (int i = 0; i < words.Count; i++)
                {
                    if (words[i].CompareTo(minimum) < 0)
                    {
                        minimum = words[i];                        
                    }
                }
                result.Add(minimum);
                words.Remove(minimum);
                minimum = words.First();
            }
            result.Add(words.First());

            // O(n)
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
