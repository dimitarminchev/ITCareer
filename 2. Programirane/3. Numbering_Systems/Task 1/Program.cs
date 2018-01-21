using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /*
    - Преобразувайте 1234 (10) в двоична и шестнадесетична бройна системи. 
    - Преобразувайте 1100101 (2) в десетична и шестнадесетична бройна системи. 
    - Преобразувайте ABC (16) в десетично и двоична бройна системи.
    */
    class Program
    {
        static void Main(string[] args)
        {
            // Десетично > Двоично            
            int number = 1234;
            Console.Write("{0} (10) = ", number);
            string binary = "";
            while (number > 0)
            {
                int reminder = number % 2;
                number /= 2;
                binary += reminder;
            }
            for(int i=binary.Length - 1;i>=0;i--)
            Console.Write(binary[i]);
            Console.WriteLine(" (2)");
        }
    }
}
