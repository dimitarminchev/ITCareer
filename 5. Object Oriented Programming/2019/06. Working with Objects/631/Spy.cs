using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

public class Spy
{
    public string StealFieldInfo(string className, params string[] fieldNames)
    {
        Type myType = Type.GetType(className);
        Console.WriteLine("Class under investigation: {0}", className);
        string fullname=myType.FullName;
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
    }
}

