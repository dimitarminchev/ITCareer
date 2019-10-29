using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Тест колко са на брой полетата в класа?
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);
        }
    }
}
