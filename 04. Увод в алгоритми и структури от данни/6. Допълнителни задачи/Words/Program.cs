namespace Words
{
    internal class Program
    {
        public static List<string> final = new List<string>();
        public static int Counter = 0;
        public static bool distincted = true;

        public static void CheckWord(char[] w)
        {
            bool goodToGo = true;

            for (int i = 0; i < w.Length - 1; i++)
            {
                if (w[i] == w[i + 1])
                {
                    goodToGo = false;
                    break;
                }
            }

            if (goodToGo)
            {
                if (distincted) Counter++;
                else
                {
                    final.Add(String.Join("", w));
                    final = final.Distinct().ToList();
                }
            }
        }

        public static void Swap(ref char a, ref char b)
        {
            if (a == b) return; // Exit
            a ^= b;
            b ^= a;
            a ^= b;
        }

        public static void GetPermutations(char[] w)
        {
            int m = w.Length - 1;
            GetPermutations(w, 0, m);
        }

        public static void GetPermutations(char[] w, int k, int m)
        {
            if (k == m)
            {
                CheckWord(w); // Exit
            }
            else
            {
                for (int i = k; i <= m; i++)
                {
                    Swap(ref w[k], ref w[i]);
                    GetPermutations(w, k + 1, m);
                    Swap(ref w[k], ref w[i]);
                }
            }
        }

        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] w = s.ToCharArray();

            if (w.Count() != w.Distinct().Count())
            {
                distincted = false;
            }

            GetPermutations(w);

            if (distincted)
            {
                Console.WriteLine(Counter);
            }
            else
            {
                final.Count();
            }
        }
    }
}