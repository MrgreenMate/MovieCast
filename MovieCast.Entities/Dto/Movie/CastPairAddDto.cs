using System.ComponentModel.DataAnnotations;

namespace MovieCast.Entities.Dto.Movie
{
    /// <summary>Szereplő-színész pár külön beküldése egy már létező filmhez.</summary>
    public class CastPairAddDto : CastPairCreateDto
    {
        [Required]
        public string MovieId { get; set; } = "";
    }
}
