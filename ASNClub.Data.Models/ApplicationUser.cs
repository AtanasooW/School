using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid();
        }
        public string? FirstName { get; set; }
        public string? Surname { get; set; }
        public string? MobileNumber { get; set; }
        public Guid AddressId { get; set; }
        public Address Address { get; set; }
        public string? Status { get; set; }
    }
}
