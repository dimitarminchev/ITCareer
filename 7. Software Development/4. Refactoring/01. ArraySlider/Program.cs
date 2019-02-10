using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.ArraySlider
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = Console.ReadLine();
            BigInteger[] jm = Regex.Split(q, "\\s+").Where(n => n != "").Select(n => BigInteger.Parse(n)).ToArray();
            var r = Console.ReadLine();
            long i = 0;
            while (r != "stop")
            {
                var ee = r.Split(' ');
                var a = long.Parse(ee[0]);
                var b = ee[1];
                var c = long.Parse(ee[2]);
                a = a % jm.Length;
                i += a;
                var pos = i % jm.Length;
                if (pos < 0)
                {
                    pos += jm.Length;
                }
                if (pos >= jm.Length)
                {
                    pos -= jm.Length;
                }
                switch (b)
                {
                    case "+":
                        if ((jm[pos] + c) < 0)
                        {
                            jm[pos] = 0;
                        }
                        else jm[pos] = jm[pos] + c;
                        break;
                    case "-":
                        if (jm[pos] < c)
                        {
                            jm[pos] = 0;
                        }
                        else jm[pos] = jm[pos] - c;
                        break;
                    case "*":
                        if ((jm[pos] * c) < 0)
                        {
                            jm[pos] = 0;
                        }
                        else jm[pos] = jm[pos] * c;
                        break;
                    case "/":
                        if ((jm[pos] / c) < 0)
                        {
                            jm[pos] = 0;
                        }
                        else jm[pos] = jm[pos] / c;
                        break;
                    case "&":
                        if ((jm[pos] & c) < 0)
                        {
                            jm[pos] = 0;
                        }
                        else jm[pos] = jm[pos] & c;
                        break;
                    case "|":
                        if ((jm[pos] | c) < 0)
                        {
                            jm[pos] = 0;
                        }
                        else jm[pos] = jm[pos] | c;
                        break;
                    case "^":
                        if ((jm[pos] ^ c) < 0)
                        {
                            jm[pos] = 0;
                        }
                        else jm[pos] = jm[pos] ^ c;
                        break;
                }
                r = Console.ReadLine();
            }
            for (int qq = 0; qq < jm.Length; qq++)
            {
                if (jm[qq] < 0)
                {
                    jm[qq] = 0;
                }
            }
            Console.WriteLine("[" + string.Join(", ", jm) + "]");
        }
    }
}
