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
                    new Dog { DogId = 1, Name = "Helo", OwnerName = "Dave", Mood = "Upbeat and calm", Age = 8, Breed = "Mixed", Size = "Medium", Location = "Portland, OR", ImgUrl = "https://drive.google.com/file/d/12-NJjKT1mrCuA1lDzVCF9-1nec04oydw/view?usp=sharing"},
                    new Dog { DogId = 2 , Name = "Bartleby", OwnerName = "Sage", Mood = "Snarky", Age = 2 , Breed = "Mixed", Size = "Small", Location = "Portland, OR", ImgUrl = "https://photos.app.goo.gl/3sn4vdSiKDbLutba8"},
                    new Dog { DogId =3 , Name = "Fin", OwnerName = "Jerrod", Mood = "Inquisitive, playful", Age = 1 , Breed = "Husky", Size = "Small", Location = "Portland, OR", ImgUrl = "https://share.icloud.com/photos/0mxrEdflh8fSsVDXz6QaL5X-A#Oak_Hills"},
                    new Dog { DogId = 4, Name = "Jeans", OwnerName = "Heather", Mood = "Hyper and wild", Age = 2, Breed = "Mized", Size = "Medium", Location = "Seattle, WA", ImgUrl = ""},
                    new Dog { DogId = 5, Name = "Remy", OwnerName = "Marci", Mood = "Sweethearted goofus", Age = 2 , Breed = "Great Pyrenees ", Size = "Big", Location = "Portland, OR", ImgUrl = "https://photos.app.goo.gl/H8VkzPHeg1M6oWa38"},
                    new Dog { DogId = 6, Name = "Neville", OwnerName = "Travis", Mood = "Loveable dunderhead", Age = 12, Breed = "Irish Setter", Size = "Large", Location = "Portland, OR", ImgUrl = "https://photos.app.goo.gl/AqDXPTwJBJTzQP2s7"},
                    new Dog { DogId = 7 , Name = "Jasper", OwnerName = "Erin", Mood = "Adorable old man", Age = 13, Breed = "Belgian Shepard", Size = "Large", Location = "Portland, OR", ImgUrl = "https://drive.google.com/file/d/1k-XzE-I0BPJK7RCZw0pfzIx0EO30IAEp/view?usp=sharing"},
                    new Dog { DogId = 8, Name = "Truvie", OwnerName = "Luke", Mood = "Sassy princess", Age = 11 , Breed = "Chihuaua", Size = "Tiny", Location = "Portland, OR", ImgUrl = "https://photos.app.goo.gl/iBdKw2wsPtGdJjSL7"},
                    new Dog { DogId = 9 , Name = "Opal", OwnerName = "Sarah", Mood = "High energy joy", Age = 1, Breed = "Corgi", Size = "small", Location = "Portland, OR", ImgUrl = "https://drive.google.com/file/d/1k-XzE-I0BPJK7RCZw0pfzIx0EO30IAEp/view?usp=sharing"},
                    new Dog { DogId = 10, Name = "Link", OwnerName = "Kris", Mood = "Anxious sweet boi", Age = 3, Breed = "German Sheppard", Size = "Big", Location = "Seaettle, WA", ImgUrl = "https://photos.google.com/share/AF1QipO5bGGUBOQx4txM8mzBV6CmO3XkdENz9JqiT9dcojGbZfvNm5EMeg72xS4xp9WVsQ/photo/AF1QipPr5iK36GruNOlXCycwJGYEO4_PglYjIDSj6kaQ?key=bzBjOTQ4dDdQMHhkREhJamRUcktNMXBDM213bFB3"},
                    new Dog { DogId = 11, Name = "Doug", OwnerName = "Julie", Mood = "All goofy, all the goofy", Age = 5 , Breed = "Bernese Mountain Dog", Size = "Huge", Location = "Portland, OR", ImgUrl = "https://drive.google.com/file/d/1tXvfrTFQKgbPZNR8j3pM775CkVYYGs0a/view?usp=sharing"},
                    new Dog { DogId = 12, Name = "Clifford", OwnerName = "Emily", Mood = "Friendly, knowledgable about all things", Age = 7, Breed = "Labrador", Size = "Giant", Location = "Portland, OR", ImgUrl = "https://cms-tc.pbskids.org/global/show-icons/circle/Clifford_200x200_white.png?mtime=20191120142954"},
                    new Dog { DogId = 13, Name = "Rexington", OwnerName = "Jim", Mood = "PURE ENERGY", Age = 4, Breed = "Blue Heeler", Size = "Medium", Location = "Tacoma, WA", ImgUrl = "https://drive.google.com/file/d/1tXvfrTFQKgbPZNR8j3pM775CkVYYGs0a/view?usp=sharing"},
                    new Dog { DogId = 14, Name = "Scabigal", OwnerName = "Elizabeth", Mood = "Tired of your crap", Age =4 , Breed = "Boston Terrier", Size = "Small", Location = "Atlanta, GA", ImgUrl = "https://pbs.twimg.com/media/EY-liJOXsAI30hz.jpg"},
                    new Dog { DogId = 15, Name = "Charmy", OwnerName = "Retsuko", Mood = "Felt cute, might delete later", Age = 7, Breed = "Shiba Inu", Size = "Small", Location = "Osaka, Japan", ImgUrl = "https://i.redd.it/7ifskt9t65mz.png"},
                    new Dog { DogId = 16, Name = "Kiva", OwnerName = "Sarah", Mood = "Slightly disgruntled, but with a heart of gold", Age = 9, Breed = "Malamute", Size = "Large", Location = "Hood River, OR", ImgUrl = "https://drive.google.com/file/d/1tXvfrTFQKgbPZNR8j3pM775CkVYYGs0a/view?usp=sharing"},
                    new Dog { DogId = 17, Name = "Opus", OwnerName = "Steve", Mood = "Tired", Age = 2, Breed = "Sharpei", Size = "Medium", Location = "Seattle, WA", ImgUrl = "https://www.harlingenveterinaryclinic.com/sites/default/files/styles/large/adaptive-image/public/chinese-sharpei-dog-breed-info.jpg?itok=JdtP42OT"},
                    new Dog { DogId = 18, Name = "Rex", OwnerName = "Dan", Mood = "Tough but fair", Age = 5, Breed = "Pitbull", Size = "Large", Location = "Canby, OR", ImgUrl = "https://drive.google.com/file/d/19tErfDf63pWKfjU3uNoMLP5MC9kmduEh/view?usp=sharing"},
                    new Dog { DogId = 19, Name = "Hercules", OwnerName = "Earl", Mood = "Slobbery", Age = 5 , Breed = "Mastiff", Size = "XXL", Location = "Los Angeles, CA", ImgUrl = "https://static.wikia.nocookie.net/thesandlot/images/0/04/Index.jpeg/revision/latest/smart/width/200/height/200?cb=20140112221255"},
                    new Dog { DogId = 20, Name = "Fido", OwnerName = "Robert", Mood = "Content with life", Age = 6, Breed = "Golden Retriever", Size = "Medium", Location = "Vancouver, WA", ImgUrl = "https://drive.google.com/file/d/1Wm16DrFK58w2Tdm0zKFbNPl7uxbqILu7/view?usp=sharing"}
                );
        }
    }
}