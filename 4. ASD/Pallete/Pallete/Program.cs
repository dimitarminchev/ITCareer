using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorSkeleton
{
    class Program
    {
        static void Main(string[] args)
        {

            int capacity = int.Parse(System.Console.ReadLine());

            CapacityList colors = new CapacityList(capacity);
            string command = "";
            do
            {
                command = System.Console.ReadLine();
                string[] commands = command.Split(' ').ToArray();
                switch (commands[0])
                {
                    case "Add":
                        int value1 = int.Parse(commands[1]);
                        int value2 = int.Parse(commands[2]);
                        int value3= int.Parse(commands[3]);

                        colors.Add(new Color(value1, value2, value3));
                        break;
                    case "CurrentSum":
                        Console.WriteLine(colors.Sum());
                        break;
                    case "CurrentState":
                        colors.PrintCurrentState();

                        break;
                    case "SortColors":
                        var sortedColors = colors.Sort();
                        if (sortedColors.Length == 0) System.Console.WriteLine("(0, 0, 0)");
                        else
                        foreach (var item in sortedColors)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "GrandeColor":
                        var allColors = colors.Sort();
                        if (allColors.Length == 0) Console.WriteLine("(0, 0, 0)");
                        else Console.WriteLine(allColors[0]);
                        break;

                }
            } while (command != "End");
        }
    
    }
}
