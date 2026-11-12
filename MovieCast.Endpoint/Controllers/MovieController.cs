using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieCast.Entities.Dto.Movie;
using MovieCast.Logic;

namespace MovieCast.Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        MovieLogic logic;

        public MovieController(MovieLogic logic)
        {
            this.logic = logic;
        }

        // Listázni authentikáció nélkül is lehet
        [HttpGet]
        public async Task<IEnumerable<MovieViewDto>> Get()
        {
            return await logic.Read();
        }

        // Létrehozni csak bejelentkezve lehet (a szereplő-színész párok is megadhatók)
        [HttpPost]
        [Authorize]
        public async Task Post(MovieCreateDto dto)
        {
            await logic.Create(dto);
        }

        // Szereplő-színész pár beküldése egy már létező filmhez
        [HttpPost("CastPair")]
        [Authorize]
        public async Task PostCastPair(CastPairAddDto dto)
        {
            await logic.AddCastPair(dto);
        }
    }
}
