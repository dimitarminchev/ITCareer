namespace Shoping
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();
            var cmd = Console.ReadLine().Split(';');
            foreach (var item in cmd)
            {
                var next = item.Split('=');
                persons.Add
                (
                    new Person(next[0], float.Parse(next[1]))
                );
            }

            var products = new List<Product>();
            cmd = Console.ReadLine().Split(';');
            foreach (var item in cmd)
            {
                var next = item.Split('=');
                products.Add
                (
                    new Product(next[0], float.Parse(next[1]))
                );
            }

            do
            {
                cmd = Console.ReadLine().Split();
                if (cmd[0] != "END")
                {
                    var product = products.FirstOrDefault(x => x.Name == cmd[1]);
                    try
                    {
                        persons.FirstOrDefault(x => x.Name == cmd[0]).AddProduct(product);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            while (cmd[0] != "END");

            foreach (var person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}