using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Core.Data.Models
{
    public class Channel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;


        public List<AppUser> AppUsers { get; set; } = new List<AppUser>();


        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
