using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Musify_DDAC_Assignment.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the Musify_DDAC_AssignmentUser class
    public class Musify_DDAC_AssignmentUser : IdentityUser
    {
        [PersonalData]
        [Required]
        public string Name { get; set; }

        [PersonalData]
        [Required]
        public string Gender { get; set; }

        
        [Required]
        public string Role { get; set; }
    }
}
