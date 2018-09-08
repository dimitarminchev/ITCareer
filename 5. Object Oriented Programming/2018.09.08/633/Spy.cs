using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _633
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

        public string AnalyzeAccessModifiers(string className)
        {
            Type analyzeClass = Type.GetType(className);
            FieldInfo[] publicFields = analyzeClass.GetFields(BindingFlags.Public | BindingFlags.Instance);
            MethodInfo[] privateGetters = analyzeClass.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            MethodInfo[] publicSetters = analyzeClass.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            Object instance = Activator.CreateInstance(analyzeClass);

            StringBuilder toReturn = new StringBuilder();
            foreach(var field in publicFields)
            {
                toReturn.AppendLine($"{field.Name} must be private!");
            }
            foreach(var getter in privateGetters.Where(x => x.Name.StartsWith("get")))
            {
                toReturn.AppendLine($"{getter.Name} have to be public!");
            }
            foreach(var setter in publicSetters.Where(x=>x.Name.StartsWith("set")))
            {
                toReturn.AppendLine($"{setter.Name} have to be private!");
            }
            return toReturn.ToString();
        }
    }
}
