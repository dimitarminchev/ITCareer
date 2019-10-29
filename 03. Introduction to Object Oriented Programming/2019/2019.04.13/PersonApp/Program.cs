using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Създавам обект инстанция на клас
            Person Ivan = new Person();

            Ivan.Name = "Ivan"; 
            Ivan.Age = 12;
            Ivan.IntroduceYourself();
        }
    }
}
