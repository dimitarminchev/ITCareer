using System;

namespace AxeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var hero = new Hero("Hero");
            var dummy = new Dummy(50, 10);
            while (!dummy.IsDead())
            {
                hero.Attack(dummy);
            }
        }
    }
}
