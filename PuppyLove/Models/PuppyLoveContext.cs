using Microsoft.EntityFrameworkCore;

namespace PuppyLove.Models
{
    public class PuppyLoveContext : DbContext
    {
        public PuppyLoveContext(DbContextOptions<PuppyLoveContext> options):base(options)
        {
        }

        public DbSet<Dog> Dogs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Dog>()
                .HasData(
                    //new Dog { DogId = , Name = "", OwnerName = "", Mood = "", Age = , Breed = "", Size = "", Location = "", ImgUrl = ""}
                    new Dog { DogId = 1, Name = "Helo", OwnerName = "Dave", Mood = "Upbeat and calm", Age = 8, Breed = "Mixed", Size = "Medium", Location = "Portland, OR", ImgUrl = "https://drive.google.com/file/d/12-NJjKT1mrCuA1lDzVCF9-1nec04oydw/view?usp=sharing"},
                    new Dog { DogId = 2 , Name = "Bartleby", OwnerName = "Sage", Mood = "Snarky", Age = 2 , Breed = "Mixed", Size = "Small", Location = "Portland, OR", ImgUrl = "https://photos.app.goo.gl/3sn4vdSiKDbLutba8"}
                );
        }
    }
}