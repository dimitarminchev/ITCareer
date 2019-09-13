using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _633
{
    class Spy
    {
        public string RevealPrivateMethods(string className)
        {
            Type myType = Type.GetType(className);
            Console.WriteLine("All Private Methods of Class: {0}", className);
            Console.WriteLine("Base Class: {0}",myType.BaseType.Name);
            string fullname = myType.FullName;
            MethodInfo[] classFields = myType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic );
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var field in classFields)
            {
                stringBuilder.AppendLine($"{field.Name}");
            }
            return stringBuilder.ToString();
        }
    }
}
