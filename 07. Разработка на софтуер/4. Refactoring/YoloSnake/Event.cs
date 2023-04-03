using System;
using System.Text;

/// <summary>
/// Refactoring Task Yolo Snake Namespace.
/// </summary>
namespace YoloSnake
{
    /// <summary>
    /// Yolo Snake Event Class
    /// </summary>
    public class Event : IComparable
    {
        public DateTime date;
        public string title;
        public string location;

        /// <summary>
        /// Yolo Snake Event class constructor.
        /// </summary>
        /// <param name="date">DateTime</param>
        /// <param name="title">Title</param>
        /// <param name="location">Location</param>
        public Event(DateTime date, string title, string location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        /// <summary>
        /// Yolo Snake CompareTo method.
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>Integer</returns>
        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int byDate = this.date.CompareTo(other.date);
            int byTitle = this.title.CompareTo(other.title);
            int byLocation = this.location.CompareTo(other.location);
            if (byDate == 0)
            {
                if (byTitle == 0)
                {
                    return byLocation;
                }
                else
                {
                    return byTitle;
                }
            }
            else
            {
                return byDate;
            }
        }

        /// <summary>
        /// Yolo Snake override To String method.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append(date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toString.Append(" | " + title);
            if (location != null && location != "")
            {
                toString.Append(" | " + location);
            }
            return toString.ToString();
        }
    }

}

