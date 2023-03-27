namespace TouristInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string unit = Console.ReadLine();
            int value = int.Parse(Console.ReadLine());
            switch (unit)
            {
                case "miles":
                    Console.WriteLine("{0} {1} = {3:f2} kilometers", value, unit, value * 1.6);
                    break;

                case "inches":
                    Console.WriteLine("{0} {1} = {3:f2} centimeters", value, unit, value * 2.54);
                    break;

                case "feet":
                    Console.WriteLine("{0} {1} = {3:f2} centimeters", value, unit, value * 30);
                    break;

                case "yards":
                    Console.WriteLine("{0} {1} = {3:f2} meters", value, unit, value * 0.91);
                    break;

                case "gallons":
                    Console.WriteLine("{0} {1} = {3:f2} litres", value, unit, value * 3.8);
                    break;
            }
        }
    }
}