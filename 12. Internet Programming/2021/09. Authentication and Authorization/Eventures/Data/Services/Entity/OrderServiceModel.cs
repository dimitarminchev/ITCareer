using System;

namespace Eventures.Data
{
    public class OrderServiceModel : IMapWith<Order>
    {
        public string Id { get; set; }

        public DateTime OrderedOn { get; set; }

        public string EventId { get; set; }

        public EventServiceModel Event { get; set; }

        public string UserId { get; set; }

        public UserServiceModel User { get; set; }

        public int TicketsCount { get; set; }
    }
}
