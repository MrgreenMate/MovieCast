using System.ComponentModel.DataAnnotations;

namespace MovieCast.Entities.Dto.Movie
{
    public class MovieCreateDto
    {
        [Required]
        [StringLength(250, MinimumLength = 1)]
        public string Title { get; set; } = "";

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Genre { get; set; } = "";

        /// <summary>Opcionális: a film szereplő-színész párjai már létrehozáskor megadhatók.</summary>
        public List<CastPairCreateDto> CastPairs { get; set; } = new();
    }
}
