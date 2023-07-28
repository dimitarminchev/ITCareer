using System.ComponentModel.DataAnnotations;

namespace RestApi.ViewModel
{
    public class MessageViewModel
    {
        [Required]
        [StringLength(250, MinimumLength = 1)]
        public string Content { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string User { get; set; }
    }
}
