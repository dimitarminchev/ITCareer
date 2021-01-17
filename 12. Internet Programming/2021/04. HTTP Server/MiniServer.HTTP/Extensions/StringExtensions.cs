namespace MiniServer.HTTP
{
    public class StringExtensions
    {
        public string Capitalize(string message)
        {
            var first = message.Substring(0, 1).ToUpper();
            var rest = message.Substring(1, message.Length - 1).ToLower();
            return first + rest;
        }
    }
}
