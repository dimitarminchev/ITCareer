using System;
using System.Linq;

namespace MiniServer.HTTP.Extensions
{
    public static class StringExtensions
    {
        public static string Capitalize(this string input)
        {
            var part1 = input.Substring(0, 1).ToUpper();
            var part2 = input.Substring(1, input.Length - 1).ToLower();
            return  part1 + part2;
        }
    }
}
