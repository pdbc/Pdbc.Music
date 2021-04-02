using System.Linq;

namespace Pdbc.Music.Data.Repositories
{
    public interface IEntityRepository<T, in TId> where T : class
    {
        /// <summary>
        /// Retrieve all entities
        /// </summary>
        /// <returns>All the entities</returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// Verifies if an object exists by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The matching entity</returns>
        bool Exists(TId id);

        /// <summary>
        /// Retrieve a single Entity by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The matching entity</returns>
        T GetById(TId id);

        /// <summary>
        /// Insert new Entity
        /// </summary>
        /// <param name="newEntity"></param>
        /// <returns>The newly created entity</returns>
        T Insert(T newEntity);

        /// <summary>
        /// Update an existing entity via the ID, all other properties will be updated
        /// </summary>
        /// <param name="changedEntity"></param>
        void Update(T changedEntity);

        /// <summary>
        /// Remove a existing Entity
        /// </summary>
        /// <param name="removedEntity"></param>
        void Delete(T removedEntity);

        /// <summary>
        /// Remove a existing Entity via ID
        /// </summary>
        /// <param name="removedEntityId"></param>
        void Delete(TId removedEntityId);

        /// <summary>
        /// Saves the changes.
        /// </summary>
        int SaveChanges();
    }

    public interface IEntityRepository<T> : IEntityRepository<T, long> where T : class
    {

    }
}