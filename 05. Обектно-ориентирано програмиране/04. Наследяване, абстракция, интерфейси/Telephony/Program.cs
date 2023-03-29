namespace Telephony
{
    public class Program
    {
        public static void Main()
        {
            var sAc = new SitesAndCalls();
            ICall call = sAc;
            call.Call(System.Console.ReadLine().Split(' '));
            IBrowse browse = sAc;
            browse.Browse(System.Console.ReadLine().Split(' '));
        }
    }
}