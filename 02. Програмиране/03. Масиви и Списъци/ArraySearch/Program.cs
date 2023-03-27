namespace ArraySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == n)
                {
                    found = true;
                    break;
                }
            }
            Console.WriteLine(found ? "Yes" : "No");
        }
    }
}