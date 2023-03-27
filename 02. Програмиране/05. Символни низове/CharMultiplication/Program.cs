namespace CharMultiplication
{
    internal class Program
    {
        static int CharMultiplication(string word1, string word2)
        {
            word1 = new string(word1.Reverse().ToArray());
            word2 = new string(word2.Reverse().ToArray());
            int shortest = Math.Min(word1.Length, word2.Length) - 1;

            string word3 = String.Empty;
            if (word1.Length > word2.Length) word3 = word1.Substring(shortest, word1.Length - 1);
            if (word1.Length < word2.Length) word3 = word2.Substring(shortest, word2.Length - 1);

            int sum = 0;
            for (int i = 0; i <= shortest; i++)
            {
                sum += (int)word1[i] * (int)word2[i];
            }
            for (int i = 0; i < word3.Length; i++)
            {
                sum += (int)word3[i];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split().ToArray();
            var word1 = line[0];
            var word2 = line[1];
            Console.WriteLine(CharMultiplication(word1, word2));
        }
    }
}