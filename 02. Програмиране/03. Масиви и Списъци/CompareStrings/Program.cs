namespace CompareStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            int min = Math.Min(arr1.Length, arr2.Length);
            for (int i = 0; i < min - 1; i++)
            {
                if (arr1[i] == arr2[i]) continue;
                if (arr1[i] < arr2[i])
                {
                    Console.WriteLine(string.Join("", arr1));
                    Console.WriteLine(string.Join("", arr2));
                    return;
                }
                if (arr1[i] > arr2[i])
                {
                    Console.WriteLine(string.Join("", arr2));
                    Console.WriteLine(string.Join("", arr1));
                    return;
                }
            }
            Console.WriteLine(string.Join("", arr1));
            Console.WriteLine(string.Join("", arr2));
        }
    }
}