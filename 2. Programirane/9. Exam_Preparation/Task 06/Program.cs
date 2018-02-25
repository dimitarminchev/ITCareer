using System;
using System.Linq;

namespace Task_06
{
    // 06. Anonymous Threat (Result: 20/100)
    class Program
    {
        static void Main(string[] args)
        {
            String[] dummy = Console.ReadLine().Split(' ');
            String[] command;  
            
            while(true)
            {
                command = Console.ReadLine().Split(' ');
                switch (command[0])
                {
                    // Сливане
                    case "merge":
                    {
                            int startIndex = int.Parse(command[1]) < 0 ? 0 : int.Parse(command[1]);
                            int endIndex = int.Parse(command[2]) > dummy.Length - 1 ? dummy.Length - 1 : int.Parse(command[2]);

                            String[] left = dummy.Take(startIndex).ToArray();
                            String[] middle = new String[1] { String.Join("", dummy.Skip(startIndex).Take(endIndex - startIndex).ToArray()) };
                            String[] right = dummy.Skip(endIndex).Take(dummy.Length - endIndex).ToArray();
                            dummy = left.Union(middle).Union(right).ToArray();

                            break;
                    }
                    // Разделяне
                    case "divide":
                    {
                            int index = int.Parse(command[1]);
                            float partitions = float.Parse(command[2]);
                            int parts = (int)Math.Ceiling(dummy[index].Length / partitions);

                            String[] left = dummy.Take(index).ToArray();
                            String[] middle = Enumerable.Range(0, dummy[index].Length / parts).Select(i => dummy[index].Substring(i * parts, parts)).ToArray();
                            String[] right = dummy.Skip(index+1).Take(dummy.Length - index).ToArray();
                            dummy = left.Union(middle).Union(right).ToArray();

                            break;
                    }
                    // Край
                    case "3:1":
                    {
                            Console.WriteLine(String.Join(" ", dummy));
                            return;                            
                    }
                }
            } 
        }
    }
}
