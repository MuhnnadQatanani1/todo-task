using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public bool IsCompleted { get; set; }

        public string UserId { get; set; } // For user-specific tasks
    }
}
