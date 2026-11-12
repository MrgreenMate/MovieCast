namespace MovieCast.Entities.Dto.Movie
{
    public class MovieViewDto
    {
        public string Id { get; set; } = "";

        public string Title { get; set; } = "";

        public string Genre { get; set; } = "";

        public List<CastPairViewDto> CastPairs { get; set; } = new();
    }
}
