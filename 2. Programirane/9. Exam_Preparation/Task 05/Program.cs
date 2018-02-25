using System;

namespace Task_05
{
    /// <summary>
    /// Task 05. Anonymous Downsite (Result: 90/100)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {           
            // Входни данни
            int n = int.Parse(Console.ReadLine());
            int key = int.Parse(Console.ReadLine());

            // Сметки
            decimal totalLoss = 0;
            double securityToken = Math.Pow(key, n);

            // Обработка
            for (int i=0;i<n;i++)
            {
                var parts = Console.ReadLine().Split(' ');
                String siteName = parts[0];
                decimal siteVisits = decimal.Parse(parts[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(parts[2]);
                decimal loss = siteVisits * siteCommercialPricePerVisit;
                totalLoss += loss;
                Console.WriteLine("{0}", siteName);
            }

            // Отпечатване на резултата
            Console.WriteLine("Total Loss: {0:f20}", totalLoss);
            Console.WriteLine("Security Token: {0}", securityToken);
        }
    }
}
