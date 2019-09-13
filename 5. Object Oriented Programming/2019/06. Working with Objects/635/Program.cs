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
            Type type = typeof(HarvestingFields);
            FieldInfo[] info = type.GetFields(BindingFlags.Public|BindingFlags.Static|BindingFlags.Instance|BindingFlags.NonPublic);

            while (true)
            {
                string cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "HARVEST": return;
                    case "protected": Console.WriteLine(string.Join("\n", info.Where(x => x.IsFamily).Select(x => $"protected {x.FieldType.Name} {x.Name}").ToArray())); break;
                    case "private": Console.WriteLine(string.Join("\n", info.Where(x => x.IsPrivate).Select(x => $"private {x.FieldType.Name} {x.Name}").ToArray())); break;
                    case "public": Console.WriteLine(string.Join("\n", info.Where(x => x.IsPublic).Select(x => $"public {x.FieldType.Name} {x.Name}").ToArray())); break;
                    case "all": Console.WriteLine(string.Join("\n", info.Select(x => $"{x.Attributes} {x.FieldType.Name} {x.Name}").ToArray())); break;
                }
            }
        }
    }
}
