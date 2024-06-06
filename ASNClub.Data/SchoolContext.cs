
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Reflection;

namespace School.Data
{
    using School.Data.Models;

    public class SchoolContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public SchoolContext(DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<BookUser> BooksUsers { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}