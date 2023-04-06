namespace EgyptianFractions
{
    public class Program
    {
        // Задача: Египедски дроби
        static void Main(string[] args)
        {
            // Примерен вход: p = 7, q = 9
            Console.Write("p=");
            int p = int.Parse(Console.ReadLine());
            Console.Write("q=");
            int q = int.Parse(Console.ReadLine());

            // Обработка
            Fraction goalFraction = new Fraction(p, q);
            Fraction currentSum = new Fraction(0, 1);
            Queue<Fraction> qFraction = new Queue<Fraction>();
            int part = 2;
            while (!(currentSum.Number == goalFraction.Number &&
                     currentSum.Denom == goalFraction.Denom))
            {
                var nextFraction = new Fraction(1, part);
                if (currentSum + nextFraction < goalFraction)
                {
                    currentSum += nextFraction;
                    qFraction.Enqueue(nextFraction);
                }
                part++;
            }

            // Изход
            Console.Write(goalFraction + " = ");
            Console.WriteLine(string.Join(" + ", qFraction));
        }
    }
}