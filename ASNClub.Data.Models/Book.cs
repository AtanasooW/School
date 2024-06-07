using System.ComponentModel.DataAnnotations;

namespace School.Data.Models
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public string Author { get; set; } = null!;
        [Required]
        public string Category { get; set; } = null!;
        public ICollection<BookUser> Rents { get; set; } = new HashSet<BookUser>();
    }
}