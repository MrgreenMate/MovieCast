using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MovieCast.Data.Helpers
{
    public class AppUser : IdentityUser
    {
        [StringLength(200)]
        public string FamilyName { get; set; } = "";

        [StringLength(200)]
        public string GivenName { get; set; } = "";
    }
}
