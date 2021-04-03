using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pdbc.Music.Domain.Model;

namespace Pdbc.Music.Data.Repositories
{
    public interface IFileInformationRepository : IEntityRepository<FileInformation>
    {
       

    }

    public class FileInformationRepository : EntityFrameworkRepository<FileInformation>, IFileInformationRepository
    {
        public FileInformationRepository(MusicDbContext dbContext) : base(dbContext)
        {
        }

        protected override DbSet<FileInformation> GetEntitiesSet()
        {
            return _dbContext.FileInformations;
        }

    }
}
