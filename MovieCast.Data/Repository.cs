using MovieCast.Entities.Helpers;

namespace MovieCast.Data
{
    public class Repository<T> where T : class, IIdEntity
    {
        MovieCastContext ctx;

        public Repository(MovieCastContext ctx)
        {
            this.ctx = ctx;
        }

        public async Task CreateAsync(T entity)
        {
            ctx.Set<T>().Add(entity);
            await ctx.SaveChangesAsync();
        }

        public IQueryable<T> GetAll()
        {
            return ctx.Set<T>();
        }
    }
}
