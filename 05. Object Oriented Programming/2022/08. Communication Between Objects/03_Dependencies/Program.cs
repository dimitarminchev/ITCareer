namespace _03_Dependencies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrimitiveCalculator calculator = new PrimitiveCalculator();
            string[] command = System.Console.ReadLine().Split().ToArray();
            while (command[0] != "End")
            {
                try
                {
                    int firstOperand = int.Parse(command[0]);
                    int secondOperand = int.Parse(command[1]);
                    int result = calculator.performCalculation(firstOperand, secondOperand);
                    Console.WriteLine(result.ToString());
                }
                catch // (Exception e)
                {
                    // Console.WriteLine($"Error: {e.Message}");
                    calculator.changeStrategy(command[1].First());
                }
                command = System.Console.ReadLine().Split().ToArray();
            }
        }
    }
}