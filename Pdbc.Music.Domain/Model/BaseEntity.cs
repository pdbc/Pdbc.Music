using System;

namespace Pdbc.Music.Domain.Model
{
    public abstract class BaseEntity : Identifiable, ICreatable
    {
        public string CreatedBy { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} - {Id}";
        }
    }
}