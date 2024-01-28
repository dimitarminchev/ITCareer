using System.ComponentModel.DataAnnotations;

namespace DatabaseFirst.Models
{
    public partial class Task
    {
		[Key]
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Status { get; set; }
    }
}
