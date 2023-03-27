namespace Hideout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            while (true)
            {
                var line = Console.ReadLine().Split().ToArray();
                var ch = char.Parse(line[0]);
                var count = int.Parse(line[1]);

                if (text.Contains(new string(ch, count)))
                {
                    var firstCharIndex = text.IndexOf(new string(ch, count));
                    var stringLength = count;

                    for (int i = firstCharIndex + count; i < text.Length; i++)
                    {
                        if (text[i] == ch)
                        {
                            stringLength++;
                        }
                    }

                    Console.WriteLine($"Hideout found at index {firstCharIndex} and it is with size {stringLength}!");
                }
            }
        }
    }
}