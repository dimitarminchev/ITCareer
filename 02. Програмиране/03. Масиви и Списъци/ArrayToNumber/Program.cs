namespace ArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] condensed = new int[nums.Length - 1];

            int n = nums.Length;
            do
            {
                for (int i = 0; i < n - 1; i++)
                    condensed[i] = nums[i] + nums[i + 1];
                nums = condensed;
                n--;
            } while (n != 1);

            Console.WriteLine(condensed[n - 1]);
        }
    }
}