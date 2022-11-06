using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Core.Data.Models
{
    public class Avatar
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Byte[] ProfilePicture { get; set; } = null!;

        public int AppUserId { get; set; }

        [Required]
        public AppUser AppUser { get; set; } = null!;
    }
}
