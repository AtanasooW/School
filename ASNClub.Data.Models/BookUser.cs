using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Models
{
    public class BookUser
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Book")]
        public Guid BookId { get; set; }
        public Book Book { get; set; } = null!;

        [Required]
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;

        public DateTime RentedOn { get; set; }
        public DateTime ReturnedAt { get; set; }
    }
}
