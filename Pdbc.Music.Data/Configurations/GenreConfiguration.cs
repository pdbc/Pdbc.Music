using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pdbc.Music.Domain.Model;
using Pdbc.Music.Domain.Validation;

namespace Pdbc.Music.Data.Configurations
{
    internal class GenreConfiguration : AuditableIdentifiableMapping<Genre>
    {
        public override void Configure(EntityTypeBuilder<Genre> builder)
        {
            base.Configure(builder);

            builder.ToTable("Genres");

            builder.Property(e => e.Name)
                .HasMaxLength(ValidationConstants.GenreNameMaxLength)
                .IsRequired();

            builder.HasIndex(e => new { e.Name }).IsUnique();

        }
    }
}
