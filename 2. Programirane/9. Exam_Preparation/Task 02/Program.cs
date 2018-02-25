using System;
using System.Linq;

namespace Task_02
{
    // 02. Icarus (Result: 100/100)
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = int.Parse(Console.ReadLine());
            int pos = start, minus = 1;
            string line = Console.ReadLine();
            do
            {
                var parts = line.Split(' ');
                String command = parts[0];
                int steps = int.Parse(parts[1]);               
                switch (command)
                {
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
                         }
                         break;
                    }
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
                            }
                            break;
                    }
                }
                line = Console.ReadLine();
            }
            while(line != "Supernova");
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
