﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PuppyLove.Models;

namespace PuppyLove.Migrations
{
    [DbContext(typeof(PuppyLoveContext))]
    [Migration("20210126165717_TestLinks")]
    partial class TestLinks
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PuppyLove.Models.Dog", b =>
                {
                    b.Property<int>("DogId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Breed");

                    b.Property<string>("ImgUrl");

                    b.Property<string>("Location");

                    b.Property<string>("Mood")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("OwnerName")
                        .IsRequired();

                    b.Property<string>("Size")
                        .IsRequired();

                    b.HasKey("DogId");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            DogId = 1,
                            Age = 8,
                            Breed = "Mixed",
                            ImgUrl = "https://i.imgur.com/LS0jkba",
                            Location = "Portland, OR",
                            Mood = "Upbeat and calm",
                            Name = "Helo",
                            OwnerName = "Dave",
                            Size = "Medium"
                        },
                        new
                        {
                            DogId = 2,
                            Age = 2,
                            Breed = "Mixed",
                            ImgUrl = "https://i.imgur.com/0rnaPDz",
                            Location = "Portland, OR",
                            Mood = "Snarky",
                            Name = "Bartleby",
                            OwnerName = "Sage",
                            Size = "Small"
                        },
                        new
                        {
                            DogId = 3,
                            Age = 1,
                            Breed = "Husky",
                            ImgUrl = "https://imgur.com/Mz05tCi",
                            Location = "Portland, OR",
                            Mood = "Inquisitive, playful",
                            Name = "Fin",
                            OwnerName = "Jerrod",
                            Size = "Small"
                        },
                        new
                        {
                            DogId = 4,
                            Age = 2,
                            Breed = "Mized",
                            ImgUrl = "https://www.northerncaliforniapomskies.com/uploads/3/0/8/6/30869529/editor/19665518-1877651202487939-8847474768448559934-n.jpg?1507766002",
                            Location = "Seattle, WA",
                            Mood = "Hyper and wild",
                            Name = "Jeans",
                            OwnerName = "Heather",
                            Size = "Medium"
                        },
                        new
                        {
                            DogId = 5,
                            Age = 2,
                            Breed = "Great Pyrenees ",
                            ImgUrl = "https://i.imgur.com/CdRyiIR.jpg",
                            Location = "Portland, OR",
                            Mood = "Sweethearted goofus",
                            Name = "Remy",
                            OwnerName = "Marci",
                            Size = "Big"
                        },
                        new
                        {
                            DogId = 6,
                            Age = 12,
                            Breed = "Irish Setter",
                            ImgUrl = "https://i.imgur.com/Gwno8aA.jpg",
                            Location = "Portland, OR",
                            Mood = "Loveable dunderhead",
                            Name = "Neville",
                            OwnerName = "Travis",
                            Size = "Large"
                        },
                        new
                        {
                            DogId = 7,
                            Age = 13,
                            Breed = "Belgian Shepard",
                            ImgUrl = "https://drive.google.com/file/d/1k-XzE-I0BPJK7RCZw0pfzIx0EO30IAEp/view?usp=sharing",
                            Location = "Portland, OR",
                            Mood = "Adorable old man",
                            Name = "Jasper",
                            OwnerName = "Erin",
                            Size = "Large"
                        },
                        new
                        {
                            DogId = 8,
                            Age = 11,
                            Breed = "Chihuaua",
                            ImgUrl = "https://i.imgur.com/BgUMDya.jpg",
                            Location = "Portland, OR",
                            Mood = "Sassy princess",
                            Name = "Truvie",
                            OwnerName = "Luke",
                            Size = "Tiny"
                        },
                        new
                        {
                            DogId = 9,
                            Age = 1,
                            Breed = "Corgi",
                            ImgUrl = "https://drive.google.com/file/d/1k-XzE-I0BPJK7RCZw0pfzIx0EO30IAEp/view?usp=sharing",
                            Location = "Portland, OR",
                            Mood = "High energy joy",
                            Name = "Opal",
                            OwnerName = "Sarah",
                            Size = "small"
                        },
                        new
                        {
                            DogId = 10,
                            Age = 3,
                            Breed = "German Sheppard",
                            ImgUrl = "https://i.imgur.com/Nh3fQoX.jpg",
                            Location = "Seattle, WA",
                            Mood = "Anxious sweet boi",
                            Name = "Link",
                            OwnerName = "Kris",
                            Size = "Big"
                        },
                        new
                        {
                            DogId = 11,
                            Age = 5,
                            Breed = "Bernese Mountain Dog",
                            ImgUrl = "https://drive.google.com/file/d/1tXvfrTFQKgbPZNR8j3pM775CkVYYGs0a/view?usp=sharing",
                            Location = "Portland, OR",
                            Mood = "All goofy, all the goofy",
                            Name = "Doug",
                            OwnerName = "Julie",
                            Size = "Huge"
                        },
                        new
                        {
                            DogId = 12,
                            Age = 7,
                            Breed = "Labrador",
                            ImgUrl = "https://cms-tc.pbskids.org/global/show-icons/circle/Clifford_200x200_white.png?mtime=20191120142954",
                            Location = "Portland, OR",
                            Mood = "Friendly, knowledgable about all things",
                            Name = "Clifford",
                            OwnerName = "Emily",
                            Size = "Giant"
                        },
                        new
                        {
                            DogId = 13,
                            Age = 4,
                            Breed = "Blue Heeler",
                            ImgUrl = "https://drive.google.com/file/d/1tXvfrTFQKgbPZNR8j3pM775CkVYYGs0a/view?usp=sharing",
                            Location = "Tacoma, WA",
                            Mood = "PURE ENERGY",
                            Name = "Rexington",
                            OwnerName = "Jim",
                            Size = "Medium"
                        },
                        new
                        {
                            DogId = 14,
                            Age = 4,
                            Breed = "Boston Terrier",
                            ImgUrl = "https://pbs.twimg.com/media/EY-liJOXsAI30hz.jpg",
                            Location = "Atlanta, GA",
                            Mood = "Tired of your crap",
                            Name = "Scabigal",
                            OwnerName = "Elizabeth",
                            Size = "Small"
                        },
                        new
                        {
                            DogId = 15,
                            Age = 7,
                            Breed = "Shiba Inu",
                            ImgUrl = "https://i.redd.it/7ifskt9t65mz.png",
                            Location = "Osaka, Japan",
                            Mood = "Felt cute, might delete later",
                            Name = "Charmy",
                            OwnerName = "Retsuko",
                            Size = "Small"
                        },
                        new
                        {
                            DogId = 16,
                            Age = 9,
                            Breed = "Malamute",
                            ImgUrl = "https://drive.google.com/file/d/1tXvfrTFQKgbPZNR8j3pM775CkVYYGs0a/view?usp=sharing",
                            Location = "Hood River, OR",
                            Mood = "Slightly disgruntled, but with a heart of gold",
                            Name = "Kiva",
                            OwnerName = "Sarah",
                            Size = "Large"
                        },
                        new
                        {
                            DogId = 17,
                            Age = 2,
                            Breed = "Sharpei",
                            ImgUrl = "https://www.harlingenveterinaryclinic.com/sites/default/files/styles/large/adaptive-image/public/chinese-sharpei-dog-breed-info.jpg?itok=JdtP42OT",
                            Location = "Seattle, WA",
                            Mood = "Tired",
                            Name = "Opus",
                            OwnerName = "Steve",
                            Size = "Medium"
                        },
                        new
                        {
                            DogId = 18,
                            Age = 5,
                            Breed = "Pitbull",
                            ImgUrl = "https://drive.google.com/file/d/19tErfDf63pWKfjU3uNoMLP5MC9kmduEh/view?usp=sharing",
                            Location = "Canby, OR",
                            Mood = "Tough but fair",
                            Name = "Rex",
                            OwnerName = "Dan",
                            Size = "Large"
                        },
                        new
                        {
                            DogId = 19,
                            Age = 5,
                            Breed = "Mastiff",
                            ImgUrl = "https://static.wikia.nocookie.net/thesandlot/images/0/04/Index.jpeg/revision/latest/smart/width/200/height/200?cb=20140112221255",
                            Location = "Los Angeles, CA",
                            Mood = "Slobbery",
                            Name = "Hercules",
                            OwnerName = "Earl",
                            Size = "XXL"
                        },
                        new
                        {
                            DogId = 20,
                            Age = 6,
                            Breed = "Golden Retriever",
                            ImgUrl = "https://drive.google.com/file/d/1Wm16DrFK58w2Tdm0zKFbNPl7uxbqILu7/view?usp=sharing",
                            Location = "Vancouver, WA",
                            Mood = "Content with life",
                            Name = "Fido",
                            OwnerName = "Robert",
                            Size = "Medium"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
