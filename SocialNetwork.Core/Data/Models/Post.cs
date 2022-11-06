using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Core.Data.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        public List<Tag> Tags { get; set; } = new List<Tag>();

        [Required]
        [MaxLength(10000)]
        public string Body { get; set; } = null!;


        public List<UserPhoto>? UserPhotos { get; set; } = new List<UserPhoto>();

        [Required]
        public string DateCreated { get; set; } = null!;
    }
}
