using Microsoft.EntityFrameworkCore;
using Pdbc.Music.Domain.Model;

namespace Pdbc.Music.Data.Repositories
{
    public interface IPlaylistRepository : IEntityRepository<Playlist>
    {


    }

    public class PlaylistRepository : EntityFrameworkRepository<Playlist>, IPlaylistRepository
    {
        public PlaylistRepository(MusicDbContext dbContext) : base(dbContext)
        {
        }

        protected override DbSet<Playlist> GetEntitiesSet()
        {
            return _dbContext.Playlists;
        }

    }
}
