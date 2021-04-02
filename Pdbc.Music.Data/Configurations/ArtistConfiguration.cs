using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pdbc.Music.Domain.Model;
using Pdbc.Music.Domain.Validation;

namespace Pdbc.Music.Data.Configurations
{
    internal class ArtistConfiguration : IdentifiableMapping<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.ToTable("Artists");

            builder.Property(e => e.Name)
                .HasMaxLength(ValidationConstants.ArtistNameMaxLength)
                .IsRequired();

            builder.HasIndex(e => new { e.Name }).IsUnique();

        }
    }
}