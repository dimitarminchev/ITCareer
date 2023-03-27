namespace MultipleSums
{
    internal class Program
    {
        static int Sum(int[] nums)
        {
            int sum = 0;
            foreach (var item in nums) sum += item;
            return sum;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] seq = new int[n];
            seq[0] = 1;

            for (int i = 1; i < n; i++)
            {
                int skip = 0, take = 0;
                if (k > i)
                {
                    skip = 0;
                    take = i;
                }
                else
                {
                    skip = i - k;
                    take = k;
                }
                var next = Sum(seq.Skip(skip).Take(take).ToArray());
                seq[i] = next;
            }
            Console.WriteLine(string.Join(" ", seq));
        }
    }
}