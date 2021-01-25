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
                    new Dog { DogId = 2 , Name = "Bartleby", OwnerName = "Sage", Mood = "Snarky", Age = 2 , Breed = "Mixed", Size = "Small", Location = "Portland, OR", ImgUrl = "https://photos.app.goo.gl/3sn4vdSiKDbLutba8"},
                    new Dog { DogId =3 , Name = "Fin", OwnerName = "Jerrod", Mood = "Inquisitive, playful", Age = 1 , Breed = "Husky", Size = "Small", Location = "Portland, OR", ImgUrl = "https://share.icloud.com/photos/0mxrEdflh8fSsVDXz6QaL5X-A#Oak_Hills"},
                    new Dog { DogId = 4, Name = "Jeans", OwnerName = "Heather", Mood = "Hyper and wild", Age = 2, Breed = "Mized", Size = "Medium", Location = "Seattle, WA", ImgUrl = ""},
                    new Dog { DogId = 5, Name = "Remy", OwnerName = "Marci", Mood = "Sweethearted goofus", Age = 2 , Breed = "Great Pyrenees ", Size = "Big", Location = "Portland, OR", ImgUrl = "https://photos.app.goo.gl/H8VkzPHeg1M6oWa38"},
                    new Dog { DogId = 6, Name = "Neville", OwnerName = "Travis", Mood = "Loveable dunderhead", Age = 12, Breed = "Irish Setter", Size = "Large", Location = "Portland, OR", ImgUrl = "https://photos.app.goo.gl/AqDXPTwJBJTzQP2s7"},
                    new Dog { DogId = 7 , Name = "Jasper", OwnerName = "Erin", Mood = "Adorable old man", Age = 13, Breed = "Belgian Shepard", Size = "Large", Location = "Portland, OR", ImgUrl = "https://drive.google.com/file/d/1k-XzE-I0BPJK7RCZw0pfzIx0EO30IAEp/view?usp=sharing"},
                    new Dog { DogId = 8, Name = "Truvie", OwnerName = "Luke", Mood = "Sassy princess", Age = 11 , Breed = "Chihuaua", Size = "Tiny", Location = "Portland, OR", ImgUrl = "https://photos.app.goo.gl/iBdKw2wsPtGdJjSL7"},
                    new Dog { DogId = 9 , Name = "Opal", OwnerName = "Sarah", Mood = "High energy joy", Age = 1, Breed = "Corgi", Size = "small", Location = "Portland, OR", ImgUrl = "https://drive.google.com/file/d/1k-XzE-I0BPJK7RCZw0pfzIx0EO30IAEp/view?usp=sharing"},
                    new Dog { DogId = 10, Name = "Link", OwnerName = "Kris", Mood = "Anxious sweet boi", Age = 3, Breed = "German Sheppard", Size = "Big", Location = "Seaettle, WA", ImgUrl = "https://photos.app.goo.gl/FbVEStTT3a198rua6"}
                );
        }
    }
}