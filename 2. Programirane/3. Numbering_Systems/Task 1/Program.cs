using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
/* Задача 1.
   - Преобразувайте 1234 (10) в двоична и шестнадесетична бройна системи. 
   - Преобразувайте 1100101 (2) в десетична и шестнадесетична бройна системи. 
   - Преобразувайте ABC (16) в десетично и двоична бройна системи.
*/
    class Program
    {
        // Конвертор от десетично в двоично
        static string dec2bin(int number)
        {
            string binary = String.Empty;
            while (number > 0)
            {
                int reminder = number % 2;
                number /= 2;
                binary += reminder;
            }
            // Reverse
            char[] reverse = binary.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }

        // Конвертор от десетично в шестнадесетично
        static string dec2hex(int number)
        {
            string hex = String.Empty;
            while (number > 0)
            {
                int reminder = number % 16;
                number /= 16;
                if (reminder < 10) hex += reminder.ToString();
                else hex += (char)(reminder + 55);
            }
            // Reverse
            char[] reverse = hex.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }

        // Конвертиране от двоично в шестнадесетично
        static string bin2hex(string bin)
        {
            // Цепим двоичното число на по четири бита
            List<string> list = new List<string>();
            while (bin.Length >= 4)
            {
                string sub = bin.Substring(bin.Length - 4, 4);
                list.Add(sub);
                bin = bin.Substring(0, bin.Length - 4);
            }
            // На остатък след цепенето добавяме нужния брой нули отпред
            switch (bin.Length)
            {
                case 0: bin = "0000"; break;
                case 1: bin = "000" + bin; break;
                case 2: bin = "00" + bin; break;
                case 3: bin = "0" + bin; break;
            }
            list.Add(bin);
            // Формиране на шестнадесетично число от четворките
            String hex = String.Empty;
            foreach (var item in list)
                switch (item)
                {
                    case "0000": hex += "0"; break;
                    case "0001": hex += "1"; break;
                    case "0010": hex += "2"; break;
                    case "0011": hex += "3"; break;
                    case "0100": hex += "4"; break;
                    case "0101": hex += "5"; break;
                    case "0110": hex += "6"; break;
                    case "0111": hex += "7"; break;
                    case "1000": hex += "8"; break;
                    case "1001": hex += "9"; break;
                    case "1010": hex += "A"; break;
                    case "1011": hex += "B"; break;
                    case "1100": hex += "C"; break;
                    case "1101": hex += "D"; break;
                    case "1110": hex += "E"; break;
                    case "1111": hex += "F"; break;
                }
            // Reverse
            char[] reverse = hex.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }

        // Главен метод
        static void Main(string[] args)
        {
            // (10) -> (2), (10) -> (16)
            Console.WriteLine("{0} (10) = {1} (2)",  1234, dec2bin(1234));
            Console.WriteLine("{0} (10) = {1} (16)", 1234, dec2hex(1234));

            // (2) -> (10), (2) -> (16)
            // Console.WriteLine("{0} (2) = {1} (10)", "1100101", bin2dec("1100101"));
            Console.WriteLine("{0} (2) = {1} (16)", "1100101", bin2hex("1100101"));
        }
    }
}
