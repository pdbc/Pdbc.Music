using Microsoft.EntityFrameworkCore;
using Pdbc.Music.Domain.Model;

namespace Pdbc.Music.Data.Repositories
{
    public interface IAlbumRepository : IEntityRepository<Album>
    {


    }

    public class AlbumRepository : EntityFrameworkRepository<Album>, IAlbumRepository
    {
        public AlbumRepository(MusicDbContext dbContext) : base(dbContext)
        {
        }

        protected override DbSet<Album> GetEntitiesSet()
        {
            return _dbContext.Albums;
        }

    }
}
