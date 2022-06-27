using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _425
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int R = input[0], C = input[1], S = input[2];
            int[][] array = new int[R][];
            for (int i = 0; i < R; i++)
            {
                array[i]= Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            for (int i = 0; i < R; i++)
            {
                int minInd = 0;
                for (int j = 0; j < R; j++)
                {
                    if(array[i][S]>array[j][S])
                    {
                        minInd = j;
                    }
                }
                int[] temp = array[i];
                array[i] = array[minInd];
                array[minInd] = temp;
            }
            for (int i = 0; i < R; i++)
            {
                Console.WriteLine(string.Join(" ",array[i]));
            }
        }
    }
}
