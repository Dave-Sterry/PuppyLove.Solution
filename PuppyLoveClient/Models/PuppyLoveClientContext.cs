using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PuppyLoveClient.Models
{
    public class PuppyLoveClientContext : IdentityDbContext<ApplicationUser>
    {
        public PuppyLoveClientContext(DbContextOptions options) : base(options) { }
        //public DbSet<Matches> Matches { get; set; } // join sniffed dogs
    }
}