namespace Telephony
{
    class SitesAndCalls : ICall, IBrowse
    {
        public void Browse(string[] sites)
        {
            for (int i = 0; i < sites.Length; i++)
                if (sites[i].Any(a => char.IsNumber(a)))
                    Program.WriteLine("Invalid URL!");
                else
                    Program.WriteLine("Browsing: " + sites[i]);
        }

        public void Call(string[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
                if (ulong.TryParse(numbers[i], out ulong useless))
                    Program.WriteLine("Calling... " + numbers[i]);
                else
                    Program.WriteLine("Invalid number!");
        }
    }
}