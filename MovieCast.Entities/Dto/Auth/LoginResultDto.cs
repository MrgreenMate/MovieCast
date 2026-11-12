namespace MovieCast.Entities.Dto.Auth
{
    public class LoginResultDto
    {
        public string AccessToken { get; set; } = "";

        public DateTime AccessTokenExpiration { get; set; }
    }
}
