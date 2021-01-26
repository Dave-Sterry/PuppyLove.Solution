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
                    new Dog { DogId = 1, Name = "Helo", OwnerName = "Dave", Mood = "Upbeat and calm", Age = 8, Breed = "Mixed", Size = "Medium", Location = "Portland, OR", ImgUrl = "https://i.imgur.com/LS0jkba.jpg"},
                    new Dog { DogId = 2 , Name = "Bartleby", OwnerName = "Sage", Mood = "Snarky", Age = 2 , Breed = "Mixed", Size = "Small", Location = "Portland, OR", ImgUrl = "https://i.imgur.com/0rnaPDz.jpg"},
                    new Dog { DogId =3 , Name = "Fin", OwnerName = "Jerrod", Mood = "Inquisitive, playful", Age = 1 , Breed = "Husky", Size = "Small", Location = "Portland, OR", ImgUrl = "https://i.imgur.com/Mz05tCi.jpg"},
                    new Dog { DogId = 4, Name = "Jeans", OwnerName = "Heather", Mood = "Hyper and wild", Age = 2, Breed = "Mized", Size = "Medium", Location = "Seattle, WA", ImgUrl = "https://www.northerncaliforniapomskies.com/uploads/3/0/8/6/30869529/editor/19665518-1877651202487939-8847474768448559934-n.jpg?1507766002"},
                    new Dog { DogId = 5, Name = "Remy", OwnerName = "Marci", Mood = "Sweethearted goofus", Age = 2 , Breed = "Great Pyrenees ", Size = "Big", Location = "Portland, OR", ImgUrl = "https://i.imgur.com/CdRyiIR.jpg"},
                    new Dog { DogId = 6, Name = "Neville", OwnerName = "Travis", Mood = "Loveable dunderhead", Age = 12, Breed = "Irish Setter", Size = "Large", Location = "Portland, OR", ImgUrl = "https://i.imgur.com/Gwno8aA.jpg"},
                    new Dog { DogId = 7 , Name = "Jasper", OwnerName = "Erin", Mood = "Adorable old man", Age = 13, Breed = "Belgian Shepard", Size = "Large", Location = "Portland, OR", ImgUrl = "https://i.pinimg.com/originals/4d/96/6e/4d966ead8837ef9d72d1f1c01fe1b53f.jpg"},
                    new Dog { DogId = 8, Name = "Truvie", OwnerName = "Luke", Mood = "Sassy princess", Age = 11 , Breed = "Chihuaua", Size = "Tiny", Location = "Portland, OR", ImgUrl = "https://i.imgur.com/BgUMDya.jpg"},
                    new Dog { DogId = 9 , Name = "Opal", OwnerName = "Sarah", Mood = "High energy joy", Age = 1, Breed = "Corgi", Size = "small", Location = "Portland, OR", ImgUrl = "https://s3.amazonaws.com/cdn-origin-etr.akc.org/wp-content/uploads/2017/11/14112506/Pembroke-Welsh-Corgi-standing-outdoors-in-the-fall.jpg"},
                    new Dog { DogId = 10, Name = "Link", OwnerName = "Kris", Mood = "Anxious sweet boi", Age = 3, Breed = "German Sheppard", Size = "Big", Location = "Seattle, WA", ImgUrl = "https://i.imgur.com/Nh3fQoX.jpg"},
                    new Dog { DogId = 11, Name = "Doug", OwnerName = "Julie", Mood = "All goofy, all the goofy", Age = 5 , Breed = "Bernese Mountain Dog", Size = "Huge", Location = "Portland, OR", ImgUrl = "https://k9weightchallenge.com/wp-content/uploads/2015/10/get-your-overweight-dog-jumping-again.jpg"},
                    new Dog { DogId = 12, Name = "Clifford", OwnerName = "Emily", Mood = "Friendly, knowledgable about all things", Age = 7, Breed = "Labrador", Size = "Giant", Location = "Portland, OR", ImgUrl = "https://cms-tc.pbskids.org/global/show-icons/circle/Clifford_200x200_white.png?mtime=20191120142954"},
                    new Dog { DogId = 13, Name = "Rexington", OwnerName = "Jim", Mood = "PURE ENERGY", Age = 4, Breed = "Blue Heeler", Size = "Medium", Location = "Tacoma, WA", ImgUrl = "https://thehappypuppysite.com/wp-content/uploads/2017/12/blue-heeler-names.jpg"},
                    new Dog { DogId = 14, Name = "Scabigal", OwnerName = "Elizabeth", Mood = "Tired of your crap", Age =4 , Breed = "Boston Terrier", Size = "Small", Location = "Atlanta, GA", ImgUrl = "https://pbs.twimg.com/media/EY-liJOXsAI30hz.jpg"},
                    new Dog { DogId = 15, Name = "Charmy", OwnerName = "Retsuko", Mood = "Felt cute, might delete later", Age = 7, Breed = "Shiba Inu", Size = "Small", Location = "Osaka, Japan", ImgUrl = "https://i.redd.it/7ifskt9t65mz.png"},
                    new Dog { DogId = 16, Name = "Kiva", OwnerName = "Sarah", Mood = "Slightly disgruntled, but with a heart of gold", Age = 9, Breed = "Malamute", Size = "Large", Location = "Hood River, OR", ImgUrl = "https://vetstreet-brightspot.s3.amazonaws.com/70/337d20a40111e087a80050568d634f/file/Alaskan-Malamute-2-578mk062311.jpg"},
                    new Dog { DogId = 17, Name = "Opus", OwnerName = "Steve", Mood = "Tired", Age = 2, Breed = "Sharpei", Size = "Medium", Location = "Seattle, WA", ImgUrl = "https://www.harlingenveterinaryclinic.com/sites/default/files/styles/large/adaptive-image/public/chinese-sharpei-dog-breed-info.jpg?itok=JdtP42OT"},
                    new Dog { DogId = 18, Name = "Rex", OwnerName = "Dan", Mood = "Tough but fair", Age = 5, Breed = "Pitbull", Size = "Large", Location = "Canby, OR", ImgUrl = "https://americanbullydaily.com/wp-content/uploads/2019/10/american-bully-2.jpg"},
                    new Dog { DogId = 19, Name = "Hercules", OwnerName = "Earl", Mood = "Slobbery", Age = 5 , Breed = "Mastiff", Size = "XXL", Location = "Los Angeles, CA", ImgUrl = "https://cdn.orvis.com/images/DBS_Mastiff_1280.jpg"},
                    new Dog { DogId = 20, Name = "Fido", OwnerName = "Robert", Mood = "Content with life", Age = 6, Breed = "Golden Retriever", Size = "Medium", Location = "Vancouver, WA", ImgUrl = "https://images2.minutemediacdn.com/image/upload/c_fill,g_auto,h_1248,w_2220/f_auto,q_auto,w_1100/v1555378804/shape/mentalfloss/istock_000009655750_small.jpg"}
                );
        }
    }
}