using System.Text;

/// <summary>
/// Refactoring Task "Yolo Snake" Namespace.
/// </summary>
namespace YoloSnake
{
    /// <summary>
    /// Yolo Snake messages class
    /// </summary>
    public static class Messages
    {
        /// <summary>
        /// Yolo Snake StringBuileder.
        /// </summary>
        public static StringBuilder output = new StringBuilder();

        /// <summary>
        /// Yolo Snake event added method.
        /// </summary>
        public static void EventAdded()
        {
            output.Append("Event added\n");
        }

        /// <summary>
        /// Yolo Snake event deleted method.
        /// </summary>
        /// <param name="x">Integer</param>
        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }
            else
            {
                output.AppendFormat("{0} events deleted\n", x);
            }
        }

        /// <summary>
        /// Yolo Snake no events found method.
        /// </summary>
        public static void NoEventsFound()
        {
            output.Append("No events found\n");
        }

        /// <summary>
        /// Yolo Snake print event method.
        /// </summary>
        /// <param name="eventToPrint">Event to print.</param>
        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                output.Append(eventToPrint + "\n");
            }
        }
    }
}
