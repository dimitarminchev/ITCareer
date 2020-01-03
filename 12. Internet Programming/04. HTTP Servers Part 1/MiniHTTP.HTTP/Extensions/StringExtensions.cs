using System.Linq;

namespace MiniHTTP.HTTP.Extensions
{
    public static class StringExtensions
    {
        public static string Capitalize(this string input)
        {
            var part1 = input.Take(1).ToString().ToUpper();
            var part2 = input.Skip(1).ToString().ToLower();
            return  part1 + part2;
        }
    }
}
