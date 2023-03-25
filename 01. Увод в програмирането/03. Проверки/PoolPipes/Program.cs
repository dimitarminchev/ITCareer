namespace PoolPipes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var V = int.Parse(Console.ReadLine());
            var P1 = int.Parse(Console.ReadLine());
            var P2 = int.Parse(Console.ReadLine());
            var H = double.Parse(Console.ReadLine());

            var t1 = P1 * H;
            var t2 = P2 * H;
            var all = t1 + t2;
            var allPROCENT = (all / V) * 100;
            var T1PROCENT = (t1 / all) * 100;
            var T2PROCENT = (t2 / all) * 100;

            if (all <= V)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%", Math.Floor(allPROCENT), Math.Floor(T1PROCENT), Math.Floor(T2PROCENT));
            }
            else if (all > V)
            {
                var AL = all - V;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", H, AL);
            }
        }
    }
}