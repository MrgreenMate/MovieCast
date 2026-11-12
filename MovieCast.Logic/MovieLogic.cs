using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MovieCast.Data;
using MovieCast.Entities.Dto.Movie;
using MovieCast.Entities.Entity;
using MovieCast.Logic.Dto;

namespace MovieCast.Logic
{
    public class MovieLogic
    {
        Repository<Movie> movieRepository;
        Repository<CastPair> castPairRepository;
        Mapper mapper;

        public MovieLogic(Repository<Movie> movieRepository, Repository<CastPair> castPairRepository, DtoProvider provider)
        {
            this.movieRepository = movieRepository;
            this.castPairRepository = castPairRepository;
            this.mapper = provider.Mapper;
        }

        // A filmek az összes szereplő-színész párjukkal együtt jönnek vissza
        public async Task<List<MovieViewDto>> Read()
        {
            var movies = await movieRepository.GetAll()
                .Include(m => m.CastPairs)
                .OrderBy(m => m.Title)
                .ToListAsync();

            return movies.Select(m => mapper.Map<MovieViewDto>(m)).ToList();
        }

        public async Task Create(MovieCreateDto dto)
        {
            var movie = mapper.Map<Movie>(dto);
            await movieRepository.CreateAsync(movie);
        }

        public async Task AddCastPair(CastPairAddDto dto)
        {
            bool movieExists = await movieRepository.GetAll().AnyAsync(m => m.Id == dto.MovieId);
            if (!movieExists)
            {
                throw new ArgumentException("Nincs ilyen film");
            }

            var pair = mapper.Map<CastPair>(dto);
            await castPairRepository.CreateAsync(pair);
        }
    }
}
