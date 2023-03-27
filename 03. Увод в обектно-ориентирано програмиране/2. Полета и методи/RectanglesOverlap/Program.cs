namespace RectanglesOverlap
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rectangle> info = new List<Rectangle>();

            int[] rectangles = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < rectangles[0]; i++)
            {
                string[] recInfo = Console.ReadLine().Split(' ').ToArray();
                info.Add
                (
                    new Rectangle()
                    {
                        ID = recInfo[0],
                        Width = int.Parse(recInfo[1]),
                        Heigh = int.Parse(recInfo[2]),
                        Horizontally = int.Parse(recInfo[3]),
                        Vertically = int.Parse(recInfo[4])
                    }
                );
            }

            string[] couples = Console.ReadLine().Split(' ');
            var first = info.Where(a => a.ID == couples[0]).First();
            var second = info.Where(a => a.ID == couples[1]).First();
            if (first.Width == second.Width && first.Heigh == second.Heigh && first.Horizontally == second.Horizontally && first.Vertically == second.Vertically)
            {
                Console.WriteLine("true");
            }
            else Console.WriteLine("false");
        }
    }
}