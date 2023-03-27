namespace CarriageOfGoods
{
    class Program
    {
        static void Main(string[] args)
        {
            var trucks = new List<Truck>();
            var cmd = Console.ReadLine().Split(';');
            foreach (var item in cmd)
            {
                var next = item.Split('=');
                try
                {
                    trucks.Add
                    (
                        new Truck(next[0], int.Parse(next[1]))
                    );
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }

            var freights = new List<Freight>();
            cmd = Console.ReadLine().Split(';');
            foreach (var item in cmd)
            {
                var next = item.Split('=');
                try
                {
                    freights.Add
                    (
                        new Freight(next[0], float.Parse(next[1]))
                    );
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }

            cmd = Console.ReadLine().Split().ToArray();
            while (cmd[0] != "END")
            {
                try
                {
                    trucks.FirstOrDefault(item => item.Name == cmd[0]).Add
                    (
                        freights.FirstOrDefault(item => item.Name == cmd[1])
                    );
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
                cmd = Console.ReadLine().Split().ToArray();
            }

            trucks.ForEach(item => Console.WriteLine(item));
        }
    }
}