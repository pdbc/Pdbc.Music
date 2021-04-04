using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pdbc.Music.Domain.Model;
using Pdbc.Music.Domain.Validation;

namespace Pdbc.Music.Data.Configurations
{
    internal class AlbumConfiguration : AuditableIdentifiableMapping<Album>
    {
        public override void Configure(EntityTypeBuilder<Album> builder)
        {
            base.Configure(builder);

            builder.ToTable("Albums");

            builder.Property(e => e.Name)
                .HasMaxLength(ValidationConstants.AlbumNameMaxLength)
                .IsRequired();


            builder.HasIndex(e => new { e.Name }).IsUnique();

            //builder.HasMany(e => e.Songs)
            //    .WithMany(y=>y.Albums);

        }
    }
}