using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_MagnetTape
{
    public class Record
    {
        public int Id { get; set; }

        public int Lenght { get; set; }

        public float Probability { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }
    }

    class Program
    {
        // Задача за магнитната лента
        static void Main(string[] args)
        {
            List<Record> tape = new List<Record>();
/* Input
1 1 0.3
2 3 0.1
3 2 0.5
4 4 0.2
END
*/
            string[] input = Console.ReadLine().Split();
            while (input[0] != "END")
            {
                tape.Add(new Record()
                {
                    Id = int.Parse(input[0]),
                    Lenght = int.Parse(input[1]),
                    Probability = float.Parse(input[2])
                });
                input = Console.ReadLine().Split();
            }

            // Process
            var result = tape.OrderByDescending(x => x.Probability / x.Lenght);

            // Print
            Console.Write("Probable Solution: ");
            Console.WriteLine(string.Join(", ", result));

        }
    }
}
