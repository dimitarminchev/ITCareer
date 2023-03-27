namespace NumeralSystemsConverter
{
    internal class Program
    {
        /// <summary>
        /// Decimal to Binary
        /// </summary>
        static string dec2bin(int number)
        {
            string binary = String.Empty;
            while (number > 0)
            {
                int reminder = number % 2;
                number /= 2;
                binary += reminder;
            }
            char[] reverse = binary.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }

        /// <summary>
        /// Decimal to Hexadecimal
        /// </summary>
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
            char[] reverse = hex.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }

        /// <summary>
        /// Binary To Decimal
        /// </summary>
        static int bin2dec(string bin)
        {
            int result = 0, pow = 0;
            for (int i = bin.Length - 1; i >= 0; i--)
            {
                var A = int.Parse(bin[i].ToString());
                result += (int)(A * Math.Pow(2, pow));
                pow++;
            }
            return result;
        }

        /// <summary>
        /// Binary to Hexadecimal
        /// </summary>
        static string bin2hex(string bin)
        {
            string hex = String.Empty;
            while (bin.Length >= 4)
            {
                string sub = bin.Substring(bin.Length - 4, 4);
                switch (sub)
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
                bin = bin.Substring(0, bin.Length - 4);
            }
            switch (bin.Length)
            {
                case 0: bin = "0000"; break;
                case 1: bin = "000" + bin; break;
                case 2: bin = "00" + bin; break;
                case 3: bin = "0" + bin; break;
            }
            switch (bin)
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
            char[] reverse = hex.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }

        /// <summary>
        /// Hexadecimal to Binary
        /// </summary>
        static string hex2bin(string hex)
        {
            string bin = String.Empty;
            for (int i = 0; i < hex.Length; i++)
                switch (hex[i])
                {
                    case '0': bin += "0000"; break;
                    case '1': bin += "0001"; break;
                    case '2': bin += "0010"; break;
                    case '3': bin += "0011"; break;
                    case '4': bin += "0100"; break;
                    case '5': bin += "0101"; break;
                    case '6': bin += "0110"; break;
                    case '7': bin += "0111"; break;
                    case '8': bin += "1000"; break;
                    case '9': bin += "1001"; break;
                    case 'A': bin += "1010"; break;
                    case 'B': bin += "1011"; break;
                    case 'C': bin += "1100"; break;
                    case 'D': bin += "1101"; break;
                    case 'E': bin += "1110"; break;
                    case 'F': bin += "1111"; break;
                }
            return bin;
        }

        /// <summary>
        /// Hexadecimal to Decimal
        /// </summary>
        static int hex2dec(string hex)
        {
            string bin = hex2bin(hex);
            return bin2dec(bin);
        }

        static void Main(string[] args)
        {
            // Convert Decimal to Binary and Hexadecimal
            Console.WriteLine("{0} (10) = {1} (2)", 1234, dec2bin(1234));
            Console.WriteLine("{0} (10) = {1} (16)", 1234, dec2hex(1234));

            // Convert Binary to Decimal and Hexadecimal
            Console.WriteLine("{0} (2) = {1} (10)", "1100101", bin2dec("1100101"));
            Console.WriteLine("{0} (2) = {1} (16)", "1100101", bin2hex("1100101"));

            // Convert Hexadecimal to Decimal and Binary
            Console.WriteLine("{0} (16) = {1} (10)", "ABC", hex2dec("ABC"));
            Console.WriteLine("{0} (16) = {1} (2)", "ABC", hex2bin("ABC"));
        }
    }
}