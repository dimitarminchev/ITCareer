using System;
using System.Linq;

namespace Task_02
{
    // 02. Icarus (Result: 100/100)
    class Program
    {
        static void Main(string[] args)
        {
            // input
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = int.Parse(Console.ReadLine());
            int pos = start;
            int minus = 1;

            // print
            //Console.WriteLine("Initial index: {0}", start);
            //Console.WriteLine("Initial state:");
            //Console.WriteLine(String.Join(" ", nums));

            // process
            string line = Console.ReadLine();
            do
            {
                var parts = line.Split(' ');
                String command = parts[0];
                int steps = int.Parse(parts[1]);
                //Console.WriteLine("Go {0} {1} steps:", command, steps);
                switch (command)
                {
                    // left
                    case "left":
                    {
                         while(steps>0)
                         {
                                pos--;
                                if (pos < 0)
                                {
                                    pos = nums.Length - 1;
                                    minus++;
                                }
                                nums[pos] -= minus;
                                steps--;
                                //Console.WriteLine(String.Join(" ", nums));
                         }
                         break;
                    }
                    // right
                    case "right":
                    {
                            while (steps > 0)
                            {                                
                                pos++;
                                if (pos > nums.Length - 1)
                                {
                                    pos = 0;
                                    minus++;
                                }
                                nums[pos] -= minus;
                                steps--;
                                //Console.WriteLine(String.Join(" ", nums));
                            }
                            break;
                    }
                }
                line = Console.ReadLine();
            }
            while(line != "Supernova");

            // print
            //Console.WriteLine("Final state:");
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
