using System;
using System.Collections.Generic;
using System.Linq;

namespace MonkeyBusiness
{
    class Program
    {
        static List<List<bool>> allSolutions = new List<List<bool>>();
        static List<bool> currentSolution = new List<bool>();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            GenerateSolutions(1, n);

            foreach(var solution in allSolutions)
            {
                for(int i = 0; i<solution.Count; i++)
                {
                    char sign = (solution[i]) ? '+' : '-';
                    Console.Write("{0}{1} ", sign, i + 1);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Total Solutions: {0}", allSolutions.Count);
        }

        static void GenerateSolutions(int currentNumber, int targetNumber)
        {
            if(currentNumber > targetNumber)
            {
                bool isSolutionValid = CheckIfSolutionIsValid();
                if(isSolutionValid)
                {
                    allSolutions.Add(currentSolution.ToArray().ToList());
                }
                return;
            }
            currentSolution.Add(true);
            GenerateSolutions(currentNumber + 1, targetNumber);
            currentSolution.RemoveAt(currentSolution.Count - 1);

            currentSolution.Add(false);
            GenerateSolutions(currentNumber + 1, targetNumber);
            currentSolution.RemoveAt(currentSolution.Count - 1);
        }

        static bool CheckIfSolutionIsValid()
        {
            int total = 0;
            for(int i = 1; i <= currentSolution.Count; i++)
            {
                total += (currentSolution[i-1] == true) ? i : -i; 
            }

            if (total == 0)
                return true;
            return false;
        }
    }
}
