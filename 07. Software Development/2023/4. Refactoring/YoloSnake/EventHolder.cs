using System;
using Wintellect.PowerCollections;

/// <summary>
/// Refactoring Task Yolo Snake Namespace.
/// </summary>
namespace YoloSnake
{
    /// <summary>
    /// Yolo Snake event holder
    /// </summary>
    public class EventHolder
    {
        MultiDictionary<string, Event> byTitle = new MultiDictionary<string, Event>(true);

        OrderedBag<Event> byDate = new OrderedBag<Event>();

        /// <summary>
        /// Yolo Snake add event
        /// </summary>
        /// <param name="date">DateTime</param>
        /// <param name="title">Title</param>
        /// <param name="location">Location</param>
        public void AddEvent(DateTime date, string title, string location)
        {
            Event newEvent = new Event(date, title, location);
            byTitle.Add(title.ToLower(), newEvent);
            byDate.Add(newEvent);
            Messages.EventAdded();
        }

        /// <summary>
        /// Yolo Snake delete event method.
        /// </summary>
        /// <param name="titleToDelete">Title to delete</param>
        public void DeleteEvents(string titleToDelete)
        {
            string title = titleToDelete.ToLower();
            int removed = 0;
            foreach (var eventToRemove in byTitle[title])
            {
                removed++;
                byDate.Remove(eventToRemove);
            }
            byTitle.Remove(title);
            Messages.EventDeleted(removed);
        }

        /// <summary>
        /// Yolo Snake list events method.
        /// </summary>
        /// <param name="date">DateTime</param>
        /// <param name="count">Counter</param>
        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.View eventsToShow = byDate.RangeFrom(new Event(date, "", ""), true);
            int showed = 0;
            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count) break;
                Messages.PrintEvent(eventToShow);

                showed++;
            }
            if (showed == 0) Messages.NoEventsFound();
        }
    }

}
