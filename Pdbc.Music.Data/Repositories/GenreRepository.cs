using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pdbc.Music.Domain.Model;

namespace Pdbc.Music.Data.Repositories
{
    public interface IGenreRepository : IEntityRepository<Genre>
    {
       

    }

    public class GenreRepository : EntityFrameworkRepository<Genre>, IGenreRepository
    {
        public GenreRepository(MusicDbContext dbContext) : base(dbContext)
        {
        }

        protected override DbSet<Genre> GetEntitiesSet()
        {
            return _dbContext.Genres;
        }

    }
}
