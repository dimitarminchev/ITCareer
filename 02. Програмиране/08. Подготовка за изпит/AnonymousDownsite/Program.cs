namespace AnonymousDownsite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var downWebsites = int.Parse(Console.ReadLine());
            var securityKey = int.Parse(Console.ReadLine());

            decimal totalLost = 0;
            var securityToken = Math.Pow(securityKey, downWebsites);
            var websites = new List<String>();

            while (downWebsites > 0)
            {
                var line = Console.ReadLine().Split().ToArray();

                websites.Add(line[0]);
                var siteVisits = int.Parse(line[1]);
                var siteCommercialPricePerVisit = decimal.Parse(line[2]);

                var siteLoss = siteVisits * siteCommercialPricePerVisit;
                totalLost += siteLoss;
                downWebsites--;
            }

            Console.WriteLine(String.Join("\n", websites));
            Console.WriteLine("Total Loss: {0:f20}", totalLost);
            Console.WriteLine("Security Token: {0}", securityToken);
        }
    }
}