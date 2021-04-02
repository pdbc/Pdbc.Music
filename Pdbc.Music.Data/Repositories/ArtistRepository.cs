using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pdbc.Music.Domain.Model;

namespace Pdbc.Music.Data.Repositories
{
    public interface IArtistRepository : IEntityRepository<Artist>
    {
       

    }

    public class ArtistRepository : EntityFrameworkRepository<Artist>, IArtistRepository
    {
        public ArtistRepository(MusicDbContext dbContext) : base(dbContext)
        {
        }

        protected override DbSet<Artist> GetEntitiesSet()
        {
            return _dbContext.Artists;
        }

    }
}
