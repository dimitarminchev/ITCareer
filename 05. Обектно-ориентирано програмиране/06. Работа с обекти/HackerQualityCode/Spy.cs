using System.Reflection;
using System.Text;

public class HackerQualityCode
{
    public string AnalyzeAcessModifiers(string className)
    {
        Type myType = Type.GetType(className);
        FieldInfo[] classFields = myType.GetFields(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public);
        
        StringBuilder stringBuilder = new StringBuilder();

        foreach (var field in classFields)
        {
            stringBuilder.AppendLine($"{field.Name} must be private!");
        }

        MethodInfo[] setters = myType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        foreach (var setter in setters.Where(x => x.Name.StartsWith("set")))
        {
            stringBuilder.AppendLine($"{setter.Name} have to be private");
        }

        MethodInfo[] getters = myType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
        foreach (var getter in getters.Where(x => x.Name.StartsWith("get")))
        {
            stringBuilder.AppendLine($"{getter.Name} have to be public");
        }

        return stringBuilder.ToString();
    }
}