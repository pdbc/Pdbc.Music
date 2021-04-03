using System;

namespace Pdbc.Music.Domain.Model
{
    public abstract class AuditableIdentifiable : Identifiable, ICreatable, IModifiable
    {
        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset ModifiedOn { get; set; }
    }
}