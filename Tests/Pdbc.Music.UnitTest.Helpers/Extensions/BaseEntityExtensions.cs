using Pdbc.Music.Domain.Model;
using Pdbc.Music.UnitTests.Base;
using System;

namespace Pdbc.Music.UnitTest.Helpers.Extensions
{
    public static class BaseEntityExtensions
    {
        public static void VerifyIdIsFilledIn(this IIdentifiable<long> entity)
        {
            entity.Id.ShouldBeGreaterThan(0);
        }
        public static void VerifyAuditModifiedPropertiesAreFilledIn(this AuditableIdentifiable entity, DateTime? modificationShouldBeAfterThisDate = null)
        {
            entity.ModifiedBy.ShouldNotBeEmpty();
            entity.ModifiedOn.ShouldNotBeNull(); //(DateTime.Now.AddSeconds(-1));

            if (modificationShouldBeAfterThisDate != null)
                entity.ModifiedOn.Ticks.ShouldBeGreaterThan(modificationShouldBeAfterThisDate.Value.Ticks);
        }

        public static void VerifyAuditCreatedPropertiesAreFilledIn(this AuditableIdentifiable entity, DateTime? creationShouldBeAfterThisDate = null)
        {
            entity.CreatedBy.ShouldNotBeEmpty();
            entity.CreatedOn.ShouldNotBeNull(); //(DateTime.Now.AddSeconds(-1));

            if (creationShouldBeAfterThisDate != null)
                entity.CreatedOn.Ticks.ShouldBeGreaterThan(creationShouldBeAfterThisDate.Value.Ticks);
        }
    }
}
