namespace BigNumbersSum
{
    internal class Program
    {
        static String Sum(String A, String B)
        {
            String C = String.Empty;

            if (A.Length < B.Length) A = new String('0', B.Length - A.Length) + A;
            else B = new String('0', A.Length - B.Length) + B;

            int j = 0, PART = 0;

            for (int i = A.Length - 1; i >= 0; i--)
            {
                int SUM = (int)A[i] + (int)B[i] - 96; // ASCII
                if (PART > 0)
                {
                    SUM += PART;
                    PART = 0;
                }
                if (SUM > 9)
                {
                    PART = SUM / 10;
                    SUM = SUM % 10;
                }
                C += SUM.ToString();
                j++;
            }

            return string.Join("", C.Reverse());
        }

        static void Main(string[] args)
        {
            String A = Console.ReadLine();
            String B = Console.ReadLine();
            Console.Write(Sum(A, B));
        }
    }
}