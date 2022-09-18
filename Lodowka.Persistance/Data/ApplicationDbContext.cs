using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Lodowka.Core.Models;

namespace Lodowka.Persistance.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Fridge> Fridges { get; set; }
        public DbSet<Product> AvailableProducts { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
    }
}