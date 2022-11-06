using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Core.Data.Models
{
    public class UserPhoto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public byte[] Bytes { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string FileExtension { get; set; } = null!;

        public decimal Size { get; set; } 

        public int PostId { get; set; } 

        [ForeignKey(nameof(PostId))]
        public Post Post { get; set; } = null!;
    }
}
