using System;
using System.Collections.Generic;

namespace Eventures.Data
{
    public class EventServiceModel : IMapWith<Event>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Place { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int TotalTickets { get; set; }

        public decimal PricePerTicket { get; set; }

        public ICollection<OrderServiceModel> Orders { get; set; }
    }
}
