using Eventures.Data;
using System;

namespace Eventures.Models
{
    public class EventListingViewModel : IMapWith<EventServiceModel>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Place { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
