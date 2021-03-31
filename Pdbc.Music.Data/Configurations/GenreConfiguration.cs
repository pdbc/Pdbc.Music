using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pdbc.Music.Domain.Model;

namespace Pdbc.Music.Data.Configurations
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genres");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name)
                .HasMaxLength(256)
                .IsRequired();

            builder.HasIndex(e => new { e.Name}).IsUnique();

        }
    }
}
