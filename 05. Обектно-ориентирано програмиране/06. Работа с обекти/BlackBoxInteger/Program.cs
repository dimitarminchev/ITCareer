using System.Reflection;

namespace BlackBoxInteger
{
    internal class Program
    {
        public static BlackBoxInteger instance;

        public static Type type;

        static void Main(string[] args)
        {
            // Fields
            type = typeof(BlackBoxInteger);
            // FieldInfo[] info = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic);

            instance = (BlackBoxInteger)Activator.CreateInstance(type, true);

            // Constructor
            // ConstructorInfo ctor = type.GetConstructor(new[] { typeof(int) });
            // object inst = ctor.Invoke(new object[] { 10 });

            // Methods
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic);

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END") return;
                string cmd = input.Substring(0, input.IndexOf("_"));
                string argument = input.Substring(input.IndexOf("_") + 1);
                Console.WriteLine(MethodInvoker(cmd, argument));
            }
        }

        public static string MethodInvoker(string cmd, string arguments)
        {
            MethodInfo singleMethod = type.GetMethod("Add", BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo field = type.GetField("innerValue", BindingFlags.NonPublic | BindingFlags.Instance);
            // int field.SetValue(instance, 5);
            switch (cmd)
            {
                case "Add": break;
                case "Subtract": singleMethod = type.GetMethod("Subtract", BindingFlags.NonPublic | BindingFlags.Instance); break;
                case "Divide": singleMethod = type.GetMethod("Divide", BindingFlags.NonPublic | BindingFlags.Instance); break;
                case "Multiply": singleMethod = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance); break;
                case "RightShift": singleMethod = type.GetMethod("RightShift", BindingFlags.NonPublic | BindingFlags.Instance); break;
                case "LeftShift": singleMethod = type.GetMethod("LeftShift", BindingFlags.NonPublic | BindingFlags.Instance); break;
            }
            var result = singleMethod.Invoke(instance, new object[] { int.Parse(arguments) });

            return ((int)field.GetValue(instance)).ToString();
        }
    }
}