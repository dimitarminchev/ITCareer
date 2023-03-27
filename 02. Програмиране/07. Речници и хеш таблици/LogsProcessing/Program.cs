namespace LogsProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> users = new Dictionary<string, int>();
            Dictionary<string, List<string>> ips = new Dictionary<string, List<string>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var log = Console.ReadLine().Split().ToArray();

                var ip = log[0];
                var user = log[1];
                var time = int.Parse(log[2]);

                if (users.ContainsKey(user))
                {
                    users[user] += time;
                    var list = ips[user];
                    if (!list.Contains(ip)) list.Add(ip);
                    ips[user] = list;
                }
                else
                {
                    users.Add(user, time);
                    var list = new List<string>();
                    list.Add(ip);
                    ips.Add(user, list);
                }
            }

            foreach (var user in users.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}: {user.Value} [{string.Join(", ", ips[user.Key])}]");
            }
        }
    }
}