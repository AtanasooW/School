using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Models
{
    public class Address
    {
        [Key]
        public Guid Id { get; set; }
        public bool IsDefault { get; set; }

        [Required]
        public string City { get; set; } = null!;

        [Required]
        public string Street1 { get; set; } = null!;

        [Required]
        public string StreetNumber { get; set; } = null!;

        [Required]
        public string PostalCode { get; set; } = null!;
    }
}
