using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventures.Data
{
    public class EventServiceModel : IMapWith<Event>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Place { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int TotalTickets { get; set; }

        [Required]
        public decimal PricePerTicket { get; set; }

        public ICollection<OrderServiceModel> Orders { get; set; }
    }
}
