namespace MagicallyChangingWords
{
    internal class Program
    {
        static bool IsReplacable(char[] letters1, char[] letters2)
        {
            var matches = new Dictionary<char, char>();
            var smallerArr = letters1.Length == (Math.Min(letters1.Length, letters2.Length)) ? letters1 : letters2;
            var biggerArr = letters1.Length == (Math.Min(letters1.Length, letters2.Length)) ? letters2 : letters1;

            for (int i = 0; i < smallerArr.Length; i++)
            {
                if (!matches.ContainsKey(smallerArr[i]))
                {
                    matches.Add(smallerArr[i], biggerArr[i]);
                }
                else
                {
                    if (matches[smallerArr[i]] == biggerArr[i])
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            for (int i = smallerArr.Length; i < biggerArr.Length; i++)
            {
                if (matches.ContainsValue(biggerArr[i]))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var word1 = input[0].ToArray();
            var word2 = input[1].ToArray();
            Console.WriteLine(IsReplacable(word1, word2));
        }
    }
}