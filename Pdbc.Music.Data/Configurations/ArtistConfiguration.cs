using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pdbc.Music.Domain.Model;
using Pdbc.Music.Domain.Validation;

namespace Pdbc.Music.Data.Configurations
{
    internal class ArtistConfiguration : AuditableIdentifiableMapping<Artist>
    {
        public override void Configure(EntityTypeBuilder<Artist> builder)
        {
            base.Configure(builder);

            builder.ToTable("Artists");

            builder.Property(e => e.Name)
                .HasMaxLength(ValidationConstants.ArtistNameMaxLength)
                .IsRequired();

            builder.HasIndex(e => new { e.Name }).IsUnique();

        }
    }
}