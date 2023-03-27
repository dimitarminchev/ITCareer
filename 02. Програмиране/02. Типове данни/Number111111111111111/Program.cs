namespace Number111111111111111
{
    internal class Program
    {
        static string Minus10(string bin)
        {
            int MIN = 0;
            String MIN10 = bin.Substring(bin.Length - 1, 1);
            for (int i = bin.Length - 2; i >= 0; i--)
            {
                if (i == bin.Length - 2)
                {
                    if (bin[i] == '1')
                    {
                        MIN10 += '0';
                        MIN = 0;
                    }
                    else
                    {
                        MIN10 += '1';
                        MIN = 1;
                    }
                }
                else
                {
                    if (MIN == 0) MIN10 += bin[i];
                    else if (bin[i] == '1')
                    {
                        MIN10 += '0';
                        MIN = 0;
                    }
                    else
                    {
                        MIN10 += '1';
                        MIN = 1;
                    }
                }
            }

            char[] reverse = MIN10.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }

        static string Plus10(string bin)
        {
            int EXTRA = 0;
            String PLUS10 = bin.Substring(bin.Length - 1, 1);
            for (int i = bin.Length - 2; i >= 0; i--)
            {
                if (i == bin.Length - 2)
                {
                    if (bin[i] == '1')
                    {
                        PLUS10 += '0';
                        EXTRA = 1;
                    }
                    else
                    {
                        PLUS10 += '1';
                        EXTRA = 0;
                    }
                }
                else
                {
                    if (bin[i] == '1' && EXTRA == 1)
                    {
                        PLUS10 += '0';
                        EXTRA = 1;
                    }
                    else
                    {
                        if (bin[i] == '1' || EXTRA == 1) PLUS10 += '1';
                        else PLUS10 += '0';
                        EXTRA = 0;
                    }
                }
            }
            if (EXTRA == 1) PLUS10 += '1';

            char[] reverse = PLUS10.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }

        static string DoubleIt(string bin)
        {
            int EXTRA = 0;
            String RES = String.Empty;
            for (int i = bin.Length - 1; i >= 0; i--)
            {
                if (i == bin.Length - 1)
                {
                    RES += '0';
                    if (bin[i] == '1') EXTRA = 1;
                    else EXTRA = 0;
                }
                else
                {
                    RES += EXTRA.ToString();
                    if (bin[i] == '1') EXTRA = 1;
                    else EXTRA = 0;
                }
            }
            if (EXTRA == 1) RES += '1';

            char[] reverse = RES.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Binary: ");
            String bin = Console.ReadLine();
            Console.WriteLine("\nMinus 10:\n{0}", Minus10(bin));
            Console.WriteLine("\nPlus 10:\n{0}", Plus10(bin));
            Console.WriteLine("\nDouble:\n{0}", DoubleIt(bin));
        }
    }
}
}