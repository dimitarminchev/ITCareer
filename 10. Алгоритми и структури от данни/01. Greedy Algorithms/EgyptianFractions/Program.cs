namespace EgyptianFractions
{
    public class Program
    {
        // Задача: Египедски дроби
        static void Main(string[] args)
        {
            Fraction goal = new Fraction(7,9); 
            Fraction next = new Fraction(1, (goal.Number + goal.Denom) / goal.Number); 
            Fraction sum = new Fraction();
            List<Fraction> selected = new List<Fraction>();

            while(true)
            {
                // Надхвърля ли търсената дроб?
                if (sum + next < goal)
                {
                    selected.Add(next);
                    sum += next;
                }

                // Получихме ли търсената дроб?
                if (sum == goal) 
                {
                    Console.WriteLine(goal + " = " + string.Join(" + ", selected ));
                    return;
                }

                // Следваща дроб ...
                next = new Fraction(1, next.Denom + 1);
            }
        }
    }
}