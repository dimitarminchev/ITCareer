namespace MergeLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lists = Console.ReadLine().Split('|').ToList();
            List<int> result = new List<int>();

            for (int index = lists.Count - 1; index >= 0; index--)
            {
                List<string> nums = lists[index].Split(' ').ToList();

                for (int index2 = 0; index2 < nums.Count; index2++)
                {
                    if (nums[index2] != "")
                    {
                        result.Add(int.Parse(nums[index2]));
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}