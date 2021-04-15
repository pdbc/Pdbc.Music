using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pdbc.Music.Domain.Model;
using Pdbc.Music.Domain.Validation;

namespace Pdbc.Music.Data.Configurations
{
    internal class SongConfiguration : AuditableIdentifiableMapping<Song>
    {
        public override void Configure(EntityTypeBuilder<Song> builder)
        {
            base.Configure(builder);

            builder.ToTable("Songs");

            builder.Property(e => e.Title)
                .HasMaxLength(ValidationConstants.SongTitleMaxLength)
                .IsRequired();

            //builder.HasOne(s => s.Album)
            //    .WithMany(a => a.Songs)
            //    .HasForeignKey(x => x.AlbumId)
            //    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(s => s.FileInformation)
                .WithOne(f => f.Song)
                .HasForeignKey<FileInformation>(x => x.SongId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(e => e.Artists)
                .WithMany(x => x.Songs);

            builder.HasMany(e => e.Genres)
                .WithMany(x => x.Songs);

        }
    }
}