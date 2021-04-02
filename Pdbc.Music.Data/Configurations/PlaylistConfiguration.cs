using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pdbc.Music.Domain.Model;
using Pdbc.Music.Domain.Validation;

namespace Pdbc.Music.Data.Configurations
{
    internal class PlaylistConfiguration : IdentifiableMapping<Playlist>
    {
        public void Configure(EntityTypeBuilder<Playlist> builder)
        {
            builder.ToTable("Playlists");

            builder.Property(e => e.Name)
                .HasMaxLength(ValidationConstants.PlaylistNameMaxLength)
                .IsRequired();

            builder.HasIndex(e => new { e.Name }).IsUnique();
        }
    }
}