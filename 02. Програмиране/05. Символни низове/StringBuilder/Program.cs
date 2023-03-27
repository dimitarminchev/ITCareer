namespace StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var cmd = Console.ReadLine().Split().ToArray();

            var sb = new System.Text.StringBuilder();
            sb.Append(input);

            switch (cmd[0])
            {
                case "Аppend":
                    sb.Append(cmd[1]);
                    break;
                case "Remove":
                    {
                        var pos = int.Parse(cmd[1]);
                        var number = int.Parse(cmd[2]);
                        sb.Remove(pos, number);
                        break;
                    }
                case "Insert":
                    {
                        var pos = int.Parse(cmd[1]);
                        var text = int.Parse(cmd[2]);
                        sb.Insert(pos, text);
                        break;
                    }
                case "Replace":
                    sb.Replace(cmd[1], cmd[2]);
                    break;
            }

            Console.WriteLine(sb.ToString());
        }
    }
}