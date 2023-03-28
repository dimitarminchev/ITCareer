namespace SumAndAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = 0; 
            float avr = 0; 
            foreach (var item in list) 
            {
                sum = sum + item;
            }
            avr = sum / list.Count; 

            Console.WriteLine("Sum={0}; Average={1:f2}", sum, avr);
        }
    }
}