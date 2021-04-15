using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Pdbc.Music.Data.Exceptions;
using Pdbc.Music.Data.Extensions;
using Pdbc.Music.Data.Repositories;
using Pdbc.Music.Domain.Model;
using Pdbc.Music.UnitTest.Helpers.Extensions;
using Pdbc.Music.UnitTests.Base;
using System;
using System.Linq;

namespace Pdbc.Music.Core.IntegrationTests.Data.Repositories
{
    public abstract class BaseRepositoryTestFixture<TEntity> : MusicIntegrationTestFixture where TEntity : AuditableIdentifiable
    {
        public IEntityRepository<TEntity> Repository { get; set; }

        public TEntity NewItem { get; set; }
        public TEntity ExistingItem { get; set; }

        protected override bool ShouldLoadTestObjects { get; set; } = true;

        protected override void Establish_context()
        {

            base.Establish_context();

            Repository = base.ServiceProvider.GetService<IEntityRepository<TEntity>>();

            // New
            NewItem = CreateNewItem();

            // Existing
            ExistingItem = CreateExistingItem();
            Repository.Insert(ExistingItem);

            Context.SaveChanges();
            //Context.SafeReload(ExistingItem);
        }

        protected abstract TEntity CreateExistingItem();

        protected abstract TEntity CreateNewItem();


        protected abstract void EditItem(TEntity entity);

        //protected abstract Action<TEntity> GetChangesToApply();


        protected int NumberOfObjectsOfType<T>() where T : class
        {
            var repository = ServiceProvider.GetService<IEntityRepository<T>>();
            return repository.GetAll().Count();
        }
        protected IEntityRepository<T> GetRepositoryFor<T>() where T : class
        {
            var repository = ServiceProvider.GetService<IEntityRepository<T>>();
            return repository;
        }

        protected override void Dispose_context()
        {
            if (NewItem != null && base.Context.Entry(NewItem).State != EntityState.Detached)
            {
                if (NewItem.Id != 0 && Repository.GetById(NewItem.Id) != null)
                {
                    // Mark as unchanged
                    base.Context.SafeReload(NewItem);
                    Repository.Delete(NewItem);
                }
            }

            if (ExistingItem != null && base.Context.Entry(ExistingItem).State != EntityState.Detached)
            {
                if (ExistingItem.Id != 0 && Repository.GetById(ExistingItem.Id) != null)
                {
                    // Mark as unchanged
                    base.Context.SafeReload(ExistingItem);
                    Repository.Delete(ExistingItem);
                }
            }
            base.Dispose_context();

        }

        [Test]
        public void Verify_object_can_be_created_by_repository()
        {
            Repository.Insert(NewItem);
            Context.SaveChanges();

            NewItem.VerifyIdIsFilledIn();
            NewItem.VerifyAuditCreatedPropertiesAreFilledIn(TestStartedDatTime);
            NewItem.VerifyAuditModifiedPropertiesAreFilledIn(TestStartedDatTime);
        }

        [Test]
        public void Verify_object_can_be_deleted()
        {
            Repository.Delete(ExistingItem);
            Context.SaveChanges();


            Repository.GetById(ExistingItem.Id).ShouldBeNull();
        }

        [Test]
        public void Verify_object_can_be_updated()
        {
            EditItem(ExistingItem);
            Context.SaveChanges();

            Repository.Update(ExistingItem);
            ExistingItem.VerifyAuditModifiedPropertiesAreFilledIn(base.TestStartedDatTime);
        }

        [Test]
        public void Verify_object_cannot_be_updated_when_optimistic_locking_is_wrong()
        {
            EditItem(ExistingItem);
            Context.SaveChanges();

            ExistingItem.ModifiedOn = DateTime.Now.AddSeconds(-60);

            Action action = () =>
            {
                Repository.Update(ExistingItem);
                Context.SaveChanges();
            };
            action.ShouldThrowException<DbUpdateConcurrencyException>();
        }

        protected void VerifyDependentObjectIsDeletedWhenDeletingEntity<TDependant>(TDependant dependentItem, TEntity entity) where TDependant : class, IIdentifiable<long>
        {
            //GetRepositoryFor<TDependant>().Insert(dependentItem);
            //Context.SaveChanges();

            Context.Entry(entity).Reload();
            Repository.Delete(entity);
            Context.SaveChanges();

            Repository.GetById(entity.Id).ShouldBeNull();
            Context.SaveChanges();

            GetRepositoryFor<TDependant>().GetById(dependentItem.Id).ShouldBeNull();
        }

        protected void VerifyDependentObjectIsNotDeletedWhenDeletingEntity<TDependant>(TDependant dependentItem, TEntity entity) where TDependant : class, IIdentifiable<long>
        {
            Repository.Delete(entity);
            Context.SaveChanges();

            // Detach all objects (force reload)
            Context.DetachAll();

            Repository.GetById(entity.Id).ShouldBeNull();
            Context.SaveChanges();

            GetRepositoryFor<TDependant>().GetById(dependentItem.Id).ShouldNotBeNull();
        }

        protected void VerifyEntityCannotBeDeletedWhenDependentItemIsAvailable<TDependant>(TDependant dependentItem, TEntity entity) where TDependant : class, IIdentifiable<long>
        {
            GetRepositoryFor<TDependant>().Insert(dependentItem);
            Context.SaveChanges();

            Action action = () =>
            {
                Repository.Delete(ExistingItem);
                Context.SaveChanges();
            };
            action.ShouldThrowException<DependentObjectStillUsedException>();

            GetRepositoryFor<TDependant>().Delete(dependentItem);
            Context.SaveChanges();
        }
    }
}
