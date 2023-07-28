using System.Collections.Generic;

namespace Eventures.Models
{
    public class AllEventsViewModel
    {
        public IEnumerable<EventListingViewModel> Events { get; set; }

        public int CurrentPage { get; set; }

        public int PageCount { get; set; }
    }
}
