using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _635
{
    class Program
    {
        static void Main(string[] args)
        {
            Type classToHarvest = typeof(RichSoilLands);
            FieldInfo[] fields;
            string command = Console.ReadLine();
            while (command != "HARVEST")
            {
                switch (command)
                {
                    case "protected":
                        fields = classToHarvest.GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Where(x => x.Attributes == FieldAttributes.Family).ToArray();
                        break;
                    case "private":
                        fields = classToHarvest.GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Where(x => x.Attributes == FieldAttributes.Private).ToArray();
                        break;
                    case "public":
                        fields = classToHarvest.GetFields(BindingFlags.Public | BindingFlags.Instance);
                        break;
                    default:
                        fields = classToHarvest.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static);
                        break;
                }

                foreach (var field in fields)
                {
                    string fieldAttribute = field.Attributes.ToString();
                    if (field.Attributes == FieldAttributes.Family) fieldAttribute = "Protected";
                    Console.WriteLine($"{fieldAttribute} {field.FieldType.Name} {field.Name}");
                }
                command = Console.ReadLine();
            }
        }
    }
}
