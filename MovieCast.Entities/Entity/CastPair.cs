using MovieCast.Entities.Helpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieCast.Entities.Entity
{
    /// <summary>Szereplő-színész pár. Egy pár pontosan egy filmhez tartozik (MovieId kötelező),
    /// egy filmhez viszont több pár is tartozhat.</summary>
    public class CastPair : IIdEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(250)]
        public string CharacterName { get; set; } = string.Empty;

        [Required]
        [StringLength(250)]
        public string ActorName { get; set; } = string.Empty;

        [Required]
        public string MovieId { get; set; } = string.Empty;

        public virtual Movie? Movie { get; set; }
    }
}
