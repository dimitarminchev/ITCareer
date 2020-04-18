using System;
namespace YoloSnake
{

    class Program
    {
        static EventHolder events = new EventHolder();

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

        private static void ListEvents(string command)
        {
            int pipeIndex = command.IndexOf('|');
            DateTime date = GetDate(command, "ListEvents");
            string countString = command.Substring(pipeIndex + 1);
            int count = int.Parse(countString);
            events.ListEvents(date, count);
        }
        private static void DeleteEvents(string command)
        {
            string title = command.Substring("DeleteEvents".Length + 1);
            events.DeleteEvents(title);
        }
        private static void AddEvent(string command)
        {
            DateTime date;
            string title;
            string location;
            GetParameters(command, "AddEvent", out date, out title, out location);
            events.AddEvent(date, title, location);
        }
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
        private static DateTime GetDate(string command, string commandType)
        {
            DateTime date = DateTime.Parse(command.Substring(commandType.Length + 1, 20));
            return date;
        }

        static void Main(string[] args)
        {
            while (ExecuteNextCommand())
            {
                // ...
            }
            Console.WriteLine(Messages.output);
        }
    }
}
