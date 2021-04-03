using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pdbc.Music.Domain.Model;

namespace Pdbc.Music.Data.Configurations
{
    internal class SongConfiguration : AuditableIdentifiableMapping<Song>
    {
        public void Configure(EntityTypeBuilder<Playlist> builder)
        {
            builder.ToTable(" Songs");
        }
    }
}