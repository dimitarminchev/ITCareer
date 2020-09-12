using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_RepresentingSumsAsSumOfGivenNominals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace _3_RepresentingNumbersWithSums
    {
        class Program
        {
            static List<List<int>> allSolutions = new List<List<int>>();
            static List<int> currentSolution = new List<int>();
            static int[] allowedNumbers;
            static void RepresentAsSums(int n, int timesFractioned)
            {
                if (n == 0 && timesFractioned > 1)
                {
                    int[] solutionToAdd = new int[currentSolution.Count];
                    currentSolution.CopyTo(solutionToAdd);
                    List<int> solutionToAddList = solutionToAdd.OrderByDescending(x => x).ToList();

                    if (CheckIfUnique(solutionToAddList))
                    {
                        allSolutions.Add(solutionToAddList);
                    }
                    return;
                }
                else if(n > 0)
                {
                    for (int k = 0; k < allowedNumbers.Length; k++)
                    {
                        currentSolution.Add(allowedNumbers[k]);
                        RepresentAsSums(n - allowedNumbers[k], timesFractioned + 1);
                        currentSolution.RemoveAt(timesFractioned);
                    }
                }
            }

            static bool CheckIfUnique(List<int> solutionToAddList)
            {
                bool isUnique = true;
                foreach (var solution in allSolutions.Where(x => x.Count == solutionToAddList.Count))
                {
                    bool broken = false;
                    for (int i = 0; i < solution.Count; i++)
                    {
                        if (solution[i] != solutionToAddList[i])
                        {
                            broken = true;
                            break;
                        }
                    }
                    if (!broken)
                    {
                        isUnique = false;
                        break;
                    }
                }
                return isUnique;
            }
            static void Main(string[] args)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int n = input[0];
                allowedNumbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x=>x).ToArray();
                RepresentAsSums(n, 0);
                allSolutions.ForEach(x => Console.WriteLine(string.Join(" + ", x)));
            }
        }
    }

}
