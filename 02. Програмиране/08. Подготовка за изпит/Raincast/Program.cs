namespace Raincast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String line = Console.ReadLine();
            String[] ValidForecast = new String[3];
            while (line != "Davai Emo")
            {
                var parts = line.Split(':');
                switch (parts[0])
                {
                    case "Type":
                        {
                            var type = parts[1].Trim(' ');
                            if (type == "Normal" || type == "Warning" || type == "Danger" &&
                                 String.IsNullOrEmpty(ValidForecast[0]))
                            {
                                ValidForecast[0] = type;
                            }
                            break;
                        }
                    case "Source":
                        {
                            var src = parts[1].Trim(' ');
                            if (!String.IsNullOrEmpty(ValidForecast[0]))
                            {
                                ValidForecast[1] = src;
                            }
                            break;
                        }
                    case "Forecast":
                        {
                            var frc = parts[1].Trim(' ');
                            if (!String.IsNullOrEmpty(ValidForecast[0]) &&
                                !String.IsNullOrEmpty(ValidForecast[1]))
                            {
                                ValidForecast[2] = frc;
                                Console.WriteLine("({0}) {1} ~ {2}", ValidForecast[0], ValidForecast[2], ValidForecast[1]);
                                ValidForecast = new String[3];
                            }
                            break;
                        }
                }
                line = Console.ReadLine();
            }
        }
    }
}