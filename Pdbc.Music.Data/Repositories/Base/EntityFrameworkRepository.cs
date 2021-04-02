using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Pdbc.Music.Data.Repositories
{
    public abstract class EntityFrameworkRepository<TEntity> : IEntityRepository<TEntity> where TEntity : class
    {
        protected readonly MusicDbContext _dbContext;
        
        protected DbSet<TEntity> DbEntities;

        protected EntityFrameworkRepository(MusicDbContext dbContext)
        {
            _dbContext = dbContext;
            DefineEntitiesSet();
        }

        protected void DefineEntitiesSet()
        {
            DbEntities = GetEntitiesSet();
        }

        protected abstract DbSet<TEntity> GetEntitiesSet();

        /// <summary>
        /// Saves the changes.
        /// </summary>
        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }

        public IQueryable<TEntity> GetAll()
        {
            return DbEntities;
        }

        public bool Exists(long id)
        {
            return GetById(id) != null;
        }

        public TEntity GetById(long id)
        {
            return DbEntities.Find(id);
        }

        public TEntity Insert(TEntity newEntity)
        {
            DbEntities.Add(newEntity);

            return newEntity;
        }

        public void Update(TEntity changedEntity)
        {
            if (DbEntities.Local.All(e => e != changedEntity))
                DbEntities.Attach(changedEntity);


            _dbContext.Entry(changedEntity).State = EntityState.Modified;
        }

        public void Delete(TEntity removedEntity)
        {
            if (removedEntity != null)
                DbEntities.Remove(removedEntity);
        }

        public void Delete(long removedEntityId)
        {
            var entity = GetById(removedEntityId);
            Delete(entity);
        }
    }
}
