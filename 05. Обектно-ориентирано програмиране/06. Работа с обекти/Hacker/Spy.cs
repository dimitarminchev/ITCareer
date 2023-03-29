using System.Reflection;
using System.Text;

namespace HackerQualityCode
{
    public class Spy
    {
        public string StealFieldInfo(string className, params string[] fieldsNames)
        {
            Console.WriteLine("Class Under Investigation: {0}", className);

            Type type = Type.GetType(className);
            string typeFullName = type.FullName;

            FieldInfo[] fields = type.GetFields
            (
                BindingFlags.Static |
                BindingFlags.Instance |
                BindingFlags.NonPublic |
                BindingFlags.Public
            );

            StringBuilder sb = new StringBuilder();
            foreach (var field in fields)
            {
                Type fieldType = type.ReflectedType;
                var testInstance = Activator.CreateInstance(type);
                var fieldValue = field.GetValue(testInstance);
                sb.Append(String.Format("{0}: {1}\n", field.Name, fieldValue.ToString()));
            }

            return sb.ToString();
        }
    }
}