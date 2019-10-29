using System;
using System.Runtime.InteropServices;

namespace _2.IntNumbers
{
    class Program
    {
        // 2. Цели числа
        static void Main(string[] args)
        {
            // Определяне на правилните типове цели числа
            sbyte a = -100;
            byte b = 128;
            short c = -3540;
            ushort d = 64876;
            uint e = 2147483648;
            int f = -1141583228;
            long g = -1223372036854775808;
            // Отпечатване
            Console.WriteLine("{0} = {1}",Marshal.SizeOf(a),a);
            Console.WriteLine("{0} = {1}", Marshal.SizeOf(b),b);
            Console.WriteLine("{0} = {1}", Marshal.SizeOf(c),c);
            Console.WriteLine("{0} = {1}", Marshal.SizeOf(d),d);
            Console.WriteLine("{0} = {1}", Marshal.SizeOf(e),e);
            Console.WriteLine("{0} = {1}", Marshal.SizeOf(f),f);
            Console.WriteLine("{0} = {1}", Marshal.SizeOf(g),g);
        }
    }
}
