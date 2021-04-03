using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pdbc.Music.Domain.Model;

namespace Pdbc.Music.Data.Repositories
{
    public interface ISongRepository : IEntityRepository<Song>
    {
       

    }

    public class SongRepository : EntityFrameworkRepository<Song>, ISongRepository
    {
        public SongRepository(MusicDbContext dbContext) : base(dbContext)
        {
        }

        protected override DbSet<Song> GetEntitiesSet()
        {
            return _dbContext.Songs;
        }

    }
}
