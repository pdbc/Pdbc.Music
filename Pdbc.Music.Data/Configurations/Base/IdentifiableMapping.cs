using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pdbc.Music.Domain.Model;

namespace Pdbc.Music.Data.Configurations
{
    internal abstract class IdentifiableMapping<T> : IEntityTypeConfiguration<T> where T : Identifiable
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                   .ValueGeneratedOnAdd();

            //   .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
