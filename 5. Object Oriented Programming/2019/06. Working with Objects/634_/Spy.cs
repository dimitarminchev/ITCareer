using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _634_
{
    class Spy
    {
        public string CollectGettersAndSetters(string investigatedClass)
        {
            Type classType = Type.GetType(investigatedClass);

            MethodInfo[] classMethods =
                classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (MethodInfo method in classMethods.Where(m => m.Name.StartsWith("get")))
            {
                stringBuilder.AppendLine($"{method.Name} will return {method.ReturnType}");
            }

            foreach (MethodInfo method in classMethods.Where(m => m.Name.StartsWith("set")))
            {
                stringBuilder.AppendLine($"{method.Name} will set field of {method.ReturnType}");
            }

            return stringBuilder.ToString().Trim();
        }
    }
}
//
 Type myType = Type.GetType(className);
        Console.WriteLine("Class under investigation: {0}", className);

        FieldInfo[] allfields = myType.GetFields(BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        StringBuilder stringBuilder = new StringBuilder();
        foreach (var field in allfields)
        {
            Type testType = myType.ReflectedType;
            var testInstance = Activator.CreateInstance(myType);
            var fieldValue = field.GetValue(testInstance);
            stringBuilder.Append(string.Format("{0} = {1}\n",field.Name, fieldValue.ToString()));
        }
        return stringBuilder.ToString();
