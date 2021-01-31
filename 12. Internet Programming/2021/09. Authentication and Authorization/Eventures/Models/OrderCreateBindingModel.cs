using Eventures.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace Eventures.Models
{
    public class OrderCreateBindingModel : IMapWith<OrderServiceModel>
    {
        [Required]
        public string EventId { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        [Display(Name = "Tickets")]
        public int TicketsCount { get; set; }
    }
}
