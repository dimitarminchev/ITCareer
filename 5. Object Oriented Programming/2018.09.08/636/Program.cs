using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace _636
{
    class Program
    {
        static void Main(string[] args)
        {
            Type blackBox = typeof(BlackBoxInteger);
            ConstructorInfo[] constructorInfo = blackBox.GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance);
            BlackBoxInteger instance = (BlackBoxInteger)constructorInfo[1].Invoke(new object[0]);

            string[] command = Console.ReadLine().Split('_').ToArray();
            while(command[0] != "END")
            {
                int number = int.Parse(command[1]);
                MethodInfo method = blackBox.GetMethod(command[0],BindingFlags.NonPublic | BindingFlags.Instance);

                method.Invoke(instance, new object[1] { number });
                FieldInfo field = blackBox.GetField("innerValue", BindingFlags.NonPublic | BindingFlags.Instance);
                Console.WriteLine(field.GetValue(instance));

                command = Console.ReadLine().Split('_').ToArray();
            }
        }
    }
}
