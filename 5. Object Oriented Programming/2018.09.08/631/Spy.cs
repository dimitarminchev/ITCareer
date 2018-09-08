using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _631
{
    public class Spy
    {
        public string StealFieldInfo(string className, string[] fieldsToInvestigate)
        {
            Type investigatedClass = Type.GetType(className);
            Object classInstance = Activator.CreateInstance(investigatedClass);

            FieldInfo[] fields = investigatedClass.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static).ToArray();
            StringBuilder toReturn = new StringBuilder();
            
            toReturn.AppendLine("Class under investigation: " + investigatedClass.Name);
            foreach (var field in fields.Where(f => fieldsToInvestigate.Contains(f.Name)))
            {
                toReturn.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return toReturn.ToString();
        }
    }
}
