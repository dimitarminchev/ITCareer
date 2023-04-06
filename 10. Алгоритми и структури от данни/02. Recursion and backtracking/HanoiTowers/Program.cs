namespace HanoiTowers
{
    public class Program
    {
        static int discs;
        static List<string> solution;
        static Stack<int> startTower = new Stack<int>();
        static Stack<int> middleTower = new Stack<int>();
        static Stack<int> endTower = new Stack<int>();

        static void SolveHanoiTowers(int n, Stack<int> startRod, Stack<int> endRod, Stack<int> tempRod)
        {
            if (n >= 1)
            {
                SolveHanoiTowers(n - 1, startRod, tempRod, endRod);
                endRod.Push(startRod.Pop());
                PrintTowers();
                SolveHanoiTowers(n - 1, tempRod, endRod, startRod);
            }
        }

        static void PrintTowers()
        {
            int[] startCopy = new int[startTower.Count];
            startTower.CopyTo(startCopy, 0);
            int[] middleCopy = new int[middleTower.Count];
            middleTower.CopyTo(middleCopy, 0);
            int[] endCopy = new int[endTower.Count];
            endTower.CopyTo(endCopy, 0);

            int startIndex = 0, middleIndex = 0, endIndex = 0;
            for (int i = 0; i < discs + 2; i++)
            {
                if (discs - startTower.Count() + 1 > i)
                {
                    Console.Write(new string(' ', discs));
                    Console.Write("│");
                    Console.Write(new string(' ', discs));
                }
                else if (startIndex < startCopy.Length)
                {
                    if (startCopy[startIndex] != discs)
                    {
                        Console.Write(new string(' ', discs - startCopy[startIndex]));
                    }
                    Console.Write("┌");
                    if (startIndex != 0)
                    {
                        Console.Write('┴');
                        Console.Write(new string('─', startCopy[startIndex] - 2));
                        Console.Write('─');
                        Console.Write(new string('─', startCopy[startIndex] - 2));
                        Console.Write('┴');
                    }
                    else
                    {
                        Console.Write(new string('─', startCopy[startIndex] - 1));
                        Console.Write('┴');
                        Console.Write(new string('─', startCopy[startIndex] - 1));
                    }
                    Console.Write("┐");
                    if (startCopy[startIndex] != discs)
                    {
                        Console.Write(new string(' ', discs - startCopy[startIndex]));
                    }

                    startIndex++;
                }
                else
                {
                    if (startIndex == startCopy.Length && startIndex != 0)
                    {
                        Console.Write(new string(' ', discs - startCopy.Last()));
                        Console.Write("└");
                        Console.Write(new string('─', startCopy.Last() * 2 - 1));
                        Console.Write("┘");
                        Console.Write(new string(' ', discs - startCopy.Last()));
                    }
                    else Console.Write(new string(' ', discs * 2 + 1));
                }

                if (discs - middleTower.Count() + 1 > i)
                {
                    Console.Write(new string(' ', discs));
                    Console.Write("│");
                    Console.Write(new string(' ', discs));
                }
                else if (middleIndex < middleCopy.Length)
                {
                    if (middleCopy[middleIndex] != discs)
                    {
                        Console.Write(new string(' ', discs - middleCopy[middleIndex]));
                    }
                    Console.Write("┌");
                    if (middleIndex != 0)
                    {
                        Console.Write('┴');
                        Console.Write(new string('─', middleCopy[middleIndex] - 2));
                        Console.Write('─');
                        Console.Write(new string('─', middleCopy[middleIndex] - 2));
                        Console.Write('┴');
                    }
                    else
                    {
                        Console.Write(new string('─', middleCopy[middleIndex] - 1));
                        Console.Write('┴');
                        Console.Write(new string('─', middleCopy[middleIndex] - 1));
                    }
                    Console.Write("┐");
                    if (middleCopy[middleIndex] != discs)
                    {
                        Console.Write(new string(' ', discs - middleCopy[middleIndex]));
                    }

                    middleIndex++;
                }
                else
                {
                    if (middleIndex == middleCopy.Length && middleIndex != 0)
                    {
                        Console.Write(new string(' ', discs - middleCopy.Last()));
                        Console.Write("└");
                        Console.Write(new string('─', middleCopy.Last() * 2 - 1));
                        Console.Write("┘");
                        Console.Write(new string(' ', discs - middleCopy.Last()));
                    }
                    else Console.Write(new string(' ', discs * 2 + 1));
                }

                if (discs - endTower.Count() + 1 > i)
                {
                    Console.Write(new string(' ', discs));
                    Console.Write("│");
                    Console.Write(new string(' ', discs));
                }
                else if (endIndex < endCopy.Length)
                {
                    if (endCopy[endIndex] != discs)
                    {
                        Console.Write(new string(' ', discs - endCopy[endIndex]));
                    }
                    Console.Write("┌");
                    if (endIndex != 0)
                    {
                        Console.Write('┴');
                        Console.Write(new string('─', endCopy[endIndex] - 2));
                        Console.Write('─');
                        Console.Write(new string('─', endCopy[endIndex] - 2));
                        Console.Write('┴');
                    }
                    else
                    {
                        Console.Write(new string('─', endCopy[endIndex] - 1));
                        Console.Write('┴');
                        Console.Write(new string('─', endCopy[endIndex] - 1));
                    }
                    Console.Write("┐");
                    if (endCopy[endIndex] != discs)
                    {
                        Console.Write(new string(' ', discs - endCopy[endIndex]));
                    }

                    endIndex++;
                }
                else
                {
                    if (endIndex == endCopy.Length && endIndex != 0)
                    {
                        Console.Write(new string(' ', discs - endCopy.Last()));
                        Console.Write("└");
                        Console.Write(new string('─', endCopy.Last() * 2 - 1));
                        Console.Write("┘");
                        Console.Write(new string(' ', discs - endCopy.Last()));
                    }
                    else Console.Write(new string(' ', discs * 2 + 1));
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            solution = new List<string>();

            discs = int.Parse(Console.ReadLine());
            for (int i = discs; i > 0; i--)
            {
                startTower.Push(i);
            }

            PrintTowers();
            SolveHanoiTowers(discs, startTower, endTower, middleTower);
        }
    }
}