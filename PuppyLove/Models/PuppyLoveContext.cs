using Microsoft.EntityFrameworkCore;

namespace PuppyLove.Models
{
    public class PuppyLoveContext : DbContext
    {
        public PuppyLoveContext(DbContextOptions<PuppyLoveContext> options):base(options)
        {
        }

        public DbSet<Dog> Dogs { get; set; }
    }
}