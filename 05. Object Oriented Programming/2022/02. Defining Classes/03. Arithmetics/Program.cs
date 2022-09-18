namespace _03._Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Сумиране на две числа
            var add = Arithmetics.Add(10, 15);
            Console.WriteLine("Add = {0}", add);

            // Умножение на две числа
            var mul = Arithmetics.Multiply(10, 15);
            Console.WriteLine("Multiply = {0}", mul);

        }
    }
}