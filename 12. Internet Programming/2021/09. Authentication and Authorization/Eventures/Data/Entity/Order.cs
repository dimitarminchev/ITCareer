using System;

namespace Eventures.Data
{
    public class Order
    {
        public string Id { get; set; }

        public DateTime OrderedOn { get; set; }

        public string EventId { get; set; }

        public Event Event { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public int TicketsCount { get; set; }
    }
}
