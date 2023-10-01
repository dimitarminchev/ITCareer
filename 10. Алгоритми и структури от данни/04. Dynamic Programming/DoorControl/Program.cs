namespace DoorControl
{
    public class Program
    {
        public class Thief
        {
            public int TimeOfArrival;
            public int Cash;
            public int LevelOfOpenness;
        }

        static void Main(string[] args)
        {
            // Input
            Console.Write("Number of thiefs: ");
            int numberOfThiefs = int.Parse(Console.ReadLine());
            Console.Write("Levels of openness: ");
            int levelsOfOpenness = int.Parse(Console.ReadLine());
            Console.Write("Working time: ");
            int workingTime = int.Parse(Console.ReadLine());

            Thief[] thiefs = new Thief[numberOfThiefs];

            Console.WriteLine("T = Time of arrival, C = Cash, P = Door openness level");
            Console.WriteLine("Format for each thief (Without the curly brackets): {T C P}");
            for (int i = 0; i < numberOfThiefs; i++)
            {
                Console.Write("Thief {0}: ", i + 1);
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                thiefs[i] = new Thief
                {
                    TimeOfArrival = input[0],
                    Cash = input[1],
                    LevelOfOpenness = input[2]
                };
            }

            int[] oldSums = new int[] { 0 };
            int[] newSums = new int[] { 0, 0 };
            
            // Process
            for (int i = 0; i < workingTime; i++)
            {
                int newSumsLength = oldSums.Length <= levelsOfOpenness ? oldSums.Length + 1 : levelsOfOpenness;
                newSums = new int[newSumsLength];
                if (newSums.Length != 2)
                {
                    for (int j = 0; j < newSums.Length; j++)
                    {
                        if (j == 0)
                        {
                            newSums[j] = Math.Max(oldSums[j], oldSums[j + 1]);
                        }
                        else if (j == oldSums.Length)
                        {
                            newSums[j] = oldSums[j - 1];
                        }
                        else if (j == oldSums.Length - 1)
                        {
                            newSums[j] = Math.Max(oldSums[j - 1], oldSums[j]);
                        }
                        else
                        {
                            newSums[j] = Math.Max(Math.Max(oldSums[j], oldSums[j + 1]), oldSums[j - 1]);
                        }
                    }
                }

                for (int j = 0; j < numberOfThiefs; j++)
                {
                    if (i == thiefs[j].TimeOfArrival && thiefs[j].LevelOfOpenness < newSums.Length)
                    {
                        newSums[thiefs[j].LevelOfOpenness] += thiefs[j].Cash;
                    }
                }
                oldSums = newSums;
            }

            Console.WriteLine("Max collected money: " + newSums.Max());
        }
    }
}