using System.ComponentModel.DataAnnotations;

namespace TaskManagerAPI.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }

        [Required]
        public string Title { get; set; }

        public string? Description { get; set; }

        public bool Completed { get; set; }

        public DateTime? DueDate { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public int UserId { get; set; }
    }
}
