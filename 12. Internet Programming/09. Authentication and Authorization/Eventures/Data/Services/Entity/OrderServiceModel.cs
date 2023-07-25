using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventures.Data
{
    public class OrderServiceModel : IMapWith<Order>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Required]
        public DateTime OrderedOn { get; set; }

        [Required]
        public string EventId { get; set; }

        public EventServiceModel Event { get; set; }

        public string UserId { get; set; }

        public UserServiceModel User { get; set; }

        [Required]
        public int TicketsCount { get; set; }
    }
}
