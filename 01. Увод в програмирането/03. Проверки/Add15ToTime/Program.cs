namespace Add15ToTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            m = m + 15;
            if (m >= 60)
            {
                h += 1;  // h = h + 1;
                m -= 60; // m = m - 60;
            }
            if (h > 23) h -= 24;
            if (m < 10) Console.WriteLine("{0}:0{1}", h, m);
            else Console.WriteLine("{0}:{1}", h, m);
        }
    }
}