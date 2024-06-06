using System.ComponentModel.DataAnnotations;

namespace School.Data.Models
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; }
        public string Author { get; set; } = null!;
        public string Category { get; set; } = null!;
        public ICollection<BookUser> Rents { get; set; } = new HashSet<BookUser>();
    }
}