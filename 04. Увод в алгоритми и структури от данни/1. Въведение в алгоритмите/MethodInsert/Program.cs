namespace MethodInsert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            int number = int.Parse(Console.ReadLine());

            bool inserted = false; 
            List<int> newList = new List<int>(); 
            foreach (var item in list)
            {
                if (inserted) 
                {
                    newList.Add(item); 
                    continue; 
                }
                if (number > item) newList.Add(item); 
                else 
                {
                    newList.Add(number); 
                    newList.Add(item); 
                    inserted = true;
                }
            }

            Console.WriteLine(string.Join(" ", newList));
        }
    }
}