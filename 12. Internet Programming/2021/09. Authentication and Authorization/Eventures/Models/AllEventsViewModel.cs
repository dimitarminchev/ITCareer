using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventures.Models
{
    public class AllEventsViewModel
    {
        public IEnumerable<EventListingViewModel> Events { get; set; }

        public int CurrentPage { get; set; }

        public int PageCount { get; set; }
    }
}
