using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _634
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

        public string RevealPrivateMethods(string className)
        {
            Type classToReveal = Type.GetType(className);
            MethodInfo[] privateMethods = classToReveal.GetMethods(BindingFlags.Instance| BindingFlags.NonPublic);

            StringBuilder toReturn = new StringBuilder();
            toReturn.AppendLine($"All Private Methods of Class: {classToReveal.Name}");
            toReturn.AppendLine($"Base class: {classToReveal.BaseType.Name}");
            foreach(var method in privateMethods)
            {
                toReturn.AppendLine(method.Name);
            }

            return toReturn.ToString();
        }

        public string CollectGettersAndSetters(string className)
        {
            Type classToCollect = Type.GetType(className);
            MethodInfo[] gettersAndSetters = classToCollect.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            MethodInfo[] getters = gettersAndSetters.Where(x => x.Name.StartsWith("get")).ToArray();
            MethodInfo[] setters = gettersAndSetters.Where(x => x.Name.StartsWith("set")).ToArray();

            StringBuilder sb = new StringBuilder();
            foreach(var getter in getters)
            {
                sb.AppendLine($"{getter.Name} will return {getter.ReturnType}");
            }
            foreach(var setter in setters)
            {
                sb.AppendLine($"{setter.Name} will set field of {setter.GetParameters().First().ParameterType}");
            }

            return sb.ToString();
        }
    }
}
