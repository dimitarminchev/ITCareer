using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            // INPUT
            List<string> allNames =
                 Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var fixedNames = new Dictionary<int, string>();
            string input = Console.ReadLine();
            while(input!="generate")
            {
                string[] inputArgs =
                     input
                    .Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                fixedNames.Add(int.Parse(inputArgs[1]), inputArgs[0]);
                input = Console.ReadLine();
            }

            //PROCESS
            var solutions = new List<List<string>>();
            var currentSolution = new List<string>();
            GenerateSeatPositions(currentSolution, solutions, allNames, fixedNames, 1);

            // OUTPUT
            solutions.ForEach(x => Console.WriteLine(string.Join(" ", x)));
        }

        private static void GenerateSeatPositions
            (
                List<string> currentSolution, 
                List<List<string>> solutions, 
                List<string> allNames, 
                Dictionary<int, string> fixedNames, 
                int currentIndex
            )
        {
            if(currentSolution.Count == allNames.Count)
            {
                solutions.Add(currentSolution.ToList());
                return;
            }
            if(fixedNames.ContainsKey(currentIndex))
            {
                currentSolution.Add(fixedNames[currentIndex]);
                GenerateSeatPositions(currentSolution, solutions, allNames, fixedNames, currentIndex + 1);
                currentSolution.Remove(fixedNames[currentIndex]);
                return;
            }
            foreach(var name in allNames.Where(x=> !fixedNames.ContainsValue(x) && !currentSolution.Contains(x)))
            {
                currentSolution.Add(name);
                GenerateSeatPositions(currentSolution, solutions, allNames, fixedNames, currentIndex + 1);
                currentSolution.Remove(name);
            }
        }
    }
}
