using System.ComponentModel.DataAnnotations;

namespace MovieCast.Entities.Dto.Auth
{
    public class UserCreateDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = "";

        [Required]
        public string Password { get; set; } = "";

        [Required]
        [StringLength(200)]
        public string FamilyName { get; set; } = "";

        [Required]
        [StringLength(200)]
        public string GivenName { get; set; } = "";
    }
}
