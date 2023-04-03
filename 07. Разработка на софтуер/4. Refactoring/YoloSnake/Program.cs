/// <summary>
/// Refactoring Task "Yolo Snake" Namespace.
/// </summary>
namespace YoloSnake
{
    /// <summary>
    /// Refactoring Task "Yolo Snake" main program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Yolo Snake events.
        /// </summary>
        static EventHolder events = new EventHolder();

        /// <summary>
        /// Yolo Snake execute next command method.
        /// </summary>
        /// <returns>Boolean: true or false</returns>
        private static bool ExecuteNextCommand()
        {
            string command = Console.ReadLine();
            switch (command[0])
            {
                case 'A': AddEvent(command); return true;
                case 'D': DeleteEvents(command); return true;
                case 'L': ListEvents(command); return true;
                case 'E': return false;
            }
            return false;
        }

        /// <summary>
        /// Yolo Snake list events method.
        /// </summary>
        /// <param name="command">Command</param>
        private static void ListEvents(string command)
        {
            int pipeIndex = command.IndexOf('|');
            DateTime date = GetDate(command, "ListEvents");
            string countString = command.Substring(pipeIndex + 1);
            int count = int.Parse(countString);
            events.ListEvents(date, count);
        }

        /// <summary>
        /// Yolo Snake delete command method.
        /// </summary>
        /// <param name="command">Command</param>
        private static void DeleteEvents(string command)
        {
            string title = command.Substring("DeleteEvents".Length + 1);
            events.DeleteEvents(title);
        }


        /// <summary>
        /// Yolo Snake add event method.
        /// </summary>
        /// <param name="command">Command</param>
        private static void AddEvent(string command)
        {
            DateTime date;
            string title;
            string location;
            GetParameters(command, "AddEvent", out date, out title, out location);
            events.AddEvent(date, title, location);
        }

        /// <summary>
        /// Yolo Snake get parameters method.
        /// </summary>
        /// <param name="commandForExecution">Command for execution</param>
        /// <param name="commandType">Command type</param>
        /// <param name="dateAndTime">DateTime</param>
        /// <param name="eventTitle">Event title</param>
        /// <param name="eventLocation">Event location</param>
        private static void GetParameters(string commandForExecution, string commandType,
                                          out DateTime dateAndTime, out string eventTitle,
                                          out string eventLocation)
        {
            dateAndTime = GetDate(commandForExecution, commandType);
            int firstPipeIndex = commandForExecution.IndexOf('|');
            int lastPipeIndex = commandForExecution.LastIndexOf('|');
            if (firstPipeIndex == lastPipeIndex)
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1).Trim();
                eventLocation = "";
            }
            else
            {
                eventTitle = commandForExecution
                             .Substring(firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1)
                             .Trim();
                eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
            }
        }

        /// <summary>
        /// Yolo Snake get date method.
        /// </summary>
        /// <param name="command">Command</param>
        /// <param name="commandType">Command type</param>
        /// <returns>DateTime</returns>
        private static DateTime GetDate(string command, string commandType)
        {
            DateTime date = DateTime.Parse(command.Substring(commandType.Length + 1, 20));
            return date;
        }

        /// <summary>
        /// Refactoring Task "Yolo Snake" main method.
        /// </summary>
        /// <example>
        /// Note: Do not now how to play this game!
        /// </example>
        /// <param name="args">No arguments needed.</param>
        static void Main(string[] args)
        {
            while (ExecuteNextCommand())
            {
                // empty
            }
            Console.WriteLine(Messages.output);
        }
    }
}
