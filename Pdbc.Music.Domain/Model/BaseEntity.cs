using System;

namespace Pdbc.Music.Domain.Model
{
    public abstract class BaseEntity<TId> : IIdentifiable<TId>, ICreatable
    {
        public TId Id { get; set; }

        public string CreatedBy { get; set; }

        public DateTimeOffset CreatedOn { get; set; }
    }
}