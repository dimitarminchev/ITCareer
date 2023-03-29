using System.Reflection;
using System.Text;

namespace HackerCollector
{
    public class Spy
    {
        public string CollectGettersAndSetters(string investigatedClass)
        {
            Type classType = Type.GetType(investigatedClass);

            MethodInfo[] classMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
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