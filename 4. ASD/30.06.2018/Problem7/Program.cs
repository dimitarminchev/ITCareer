using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class Program
    {
        /* Problem 7. Подреждане на думи
            Определете сложността на програма, която чете от конзолата последователност от думи 
            (символни низове на един ред, разделени с интервал). Подредете ги по азбучен ред. 
            Запазете последователността в List<string>
        */
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            for(int i=0;i<words.Count;i++) 
            {
                string minimum = words[i];
                int minimumPos = i;
                for(int k=i;k<words.Count;k++) 
                {
                    if(minimum.CompareTo(words[k])>0) 
                    {
                        minimum = words[k];
                        minimumPos = k;
                    }
                }
                words[minimumPos] = words[i];
                words[i] = minimum;
            }
            Console.WriteLine(string.Join(" ", words));
            // Total: O(N^2)
        }
    }
}
