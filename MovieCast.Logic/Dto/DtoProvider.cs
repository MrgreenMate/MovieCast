using AutoMapper;
using MovieCast.Entities.Dto.Movie;
using MovieCast.Entities.Entity;

namespace MovieCast.Logic.Dto
{
    public class DtoProvider
    {
        public Mapper Mapper { get; }

        public DtoProvider()
        {
            Mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CastPairCreateDto, CastPair>()
                    .ForMember(d => d.Id, o => o.Ignore())
                    .ForMember(d => d.MovieId, o => o.Ignore())
                    .ForMember(d => d.Movie, o => o.Ignore());
                cfg.CreateMap<CastPairAddDto, CastPair>()
                    .ForMember(d => d.Id, o => o.Ignore())
                    .ForMember(d => d.Movie, o => o.Ignore());
                cfg.CreateMap<MovieCreateDto, Movie>()
                    .ForMember(d => d.Id, o => o.Ignore());

                cfg.CreateMap<CastPair, CastPairViewDto>();
                cfg.CreateMap<Movie, MovieViewDto>();
            }));
        }
    }
}
