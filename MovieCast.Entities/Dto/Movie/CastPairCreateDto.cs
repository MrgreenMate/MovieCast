using System.ComponentModel.DataAnnotations;

namespace MovieCast.Entities.Dto.Movie
{
    public class CastPairCreateDto
    {
        [Required]
        [StringLength(250, MinimumLength = 1)]
        public string CharacterName { get; set; } = "";

        [Required]
        [StringLength(250, MinimumLength = 1)]
        public string ActorName { get; set; } = "";
    }
}
