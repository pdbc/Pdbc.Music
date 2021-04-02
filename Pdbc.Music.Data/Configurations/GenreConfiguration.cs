using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pdbc.Music.Domain.Model;
using Pdbc.Music.Domain.Validation;

namespace Pdbc.Music.Data.Configurations
{
    internal class GenreConfiguration : IdentifiableMapping<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genres");

            builder.Property(e => e.Name)
                .HasMaxLength(ValidationConstants.GenreNameMaxLength)
                .IsRequired();

            builder.HasIndex(e => new { e.Name}).IsUnique();

        }
    }
}
