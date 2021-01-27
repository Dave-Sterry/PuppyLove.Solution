using System.ComponentModel.DataAnnotations;

namespace PuppyLove.Models
{
    public class Dog
    {
        public int DogId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string OwnerName { get; set; }
        public string User { get; set; }
        [Required]
        public string Mood { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        [Required]
        public string Size { get; set; }
        public string Location { get; set; }
        public string ImgUrl { get; set; }

    }
}
