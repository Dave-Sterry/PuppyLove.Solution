using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PuppyLoveClient.Models
{
    public class PuppyLoveClientContext : IdentityDbContext<ApplicationUser>
    {
        public PuppyLoveClientContext(DbContextOptions<PuppyLoveClientContext> options):base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        //public DbSet<Matches> Matches { get; set; } // join sniffed dogs
    }
}