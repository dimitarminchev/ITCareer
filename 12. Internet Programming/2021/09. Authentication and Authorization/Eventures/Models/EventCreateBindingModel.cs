using Eventures.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace Eventures.Models
{
    public class EventCreateBindingModel : IMapWith<EventServiceModel>
    {
        [Required]
        [StringLength(100, MinimumLength = 10)]
        public string Name { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Place { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Required]
        [Display(Name = "Total Tickets")]
        [Range(1, int.MaxValue)]
        public int TotalTickets { get; set; }

        [Required]
        [Display(Name = "Price Per Ticket")]
        public decimal PricePerTicket { get; set; }
    }
}
