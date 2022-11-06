using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Core.Data.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string AboutMe { get; set; } = null!;

        public Avatar? Avatar { get; set; }
    }
}
