using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _482
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
            List<IBirthday> citizensAndPets = new List<IBirthday>();
            string[] line = Console.ReadLine().Split().ToArray();

            while(line[0] != "End")
            {
                if(line[0] == "Citizen")
                {
                    DateTime birthDay = DateTime.ParseExact
                    (
                        line[4], 
                        "dd/MM/yyyy", 
                        System.Globalization.CultureInfo.InvariantCulture
                    );

                    citizensAndPets.Add(new Citizen(line[1], int.Parse(line[2]), line[3], birthDay));
                }
                else if(line[0] == "Pet")
                {
                    DateTime birthDay = DateTime.ParseExact
                    (
                        line[2],
                        "dd/MM/yyyy",
                        System.Globalization.CultureInfo.InvariantCulture
                    );

                    citizensAndPets.Add(new Pet(line[1], birthDay));
                }
                line = Console.ReadLine().Split().ToArray();
            }

            int year = int.Parse(Console.ReadLine());

            foreach(var item in citizensAndPets)
            {
                if(year == item.birthday.Year)
                {
                    WriteLine(item.birthday.ToString("dd/MM/yyyy"));
                }
            }
        }
    }
}
