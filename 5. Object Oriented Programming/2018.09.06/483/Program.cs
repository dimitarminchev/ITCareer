using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _483
{
    class Program
    {
        static void WriteLine(object text)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<IBuyer> buyers = new List<IBuyer>();
            for(int i=1;i<=n;i++)
            {
                string[] line = Console.ReadLine().Split().ToArray();
                if(line.Length == 4)
                {
                    DateTime birthday = DateTime.ParseExact
                    (
                        line[3],
                        "dd/MM/yyyy",
                        System.Globalization.CultureInfo.InvariantCulture
                    );

                    buyers.Add(new Citizen(line[0], int.Parse(line[1]), line[2], birthday));
                }
                else
                {
                    buyers.Add(new Rebel(line[0], int.Parse(line[1]), line[2]));
                }
            }

            string name = Console.ReadLine();
            while(name!="End")
            {
                IBuyer[] buyer = buyers.Where(x => x.name == name).ToArray();
                if (buyer.Length != 0) buyer.First().BuyFood();
                name = Console.ReadLine();
            }

            int food = 0;
            foreach(var item in buyers)
            {
                food += item.food;
            }
            WriteLine(food);
        }
    }
}
