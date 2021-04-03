using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pdbc.Music.Domain.Model;

namespace Pdbc.Music.Data.Configurations
{
    internal class SongConfiguration : AuditableIdentifiableMapping<Song>
    {
        public override void Configure(EntityTypeBuilder<Song> builder)
        {
            base.Configure(builder);

            builder.ToTable(" Songs");
        }
    }
}