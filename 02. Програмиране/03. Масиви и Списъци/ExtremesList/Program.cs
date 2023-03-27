namespace ExtremesList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            int min = nums[0], max = nums[0];
            foreach (var item in nums)
            {
                if (item < min) min = item;
                if (item > max) max = item;
            }

            for (int index = 0; index < nums.Count; index++)
            {
                if (nums[index] == min || nums[index] == max)
                {
                    result.Add(nums[index]);
                }
            }

            result.Sort();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}