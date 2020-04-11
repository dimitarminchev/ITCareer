using System;

namespace Task_04.Models
{
    class Password
    {
        public int n;
        public int N
        {
            get { return n; }
            set
            {
                if (value > 0 && value < 10) n = value;
                else throw new Exception("Incorrrect n value");
            }
        }
        public int l;
        public int L
        {
            get { return l; }
            set
            {
                if (value > 0 && value < 10) l = value;
                else throw new Exception("Incorrrect l value");
            }
        }
        public Password(int n, int l)
        {
            N = n;
            L = l;
        }

        public string Calculate()
        {
            string result = String.Empty;
            for (int a = 1; a <= n; a++)
            {
                for (int b = 1; b <= n; b++)
                {
                    for (char c = 'a'; c < 'a' + l; c++)
                    {
                        for (char d = 'a'; d < 'a' + l; d++)
                        {
                            for (int e = 1; e <= n; e++)
                            {
                                if (e > a && e > b) result += $"{a}{b}{c}{d}{e}  ";
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}

