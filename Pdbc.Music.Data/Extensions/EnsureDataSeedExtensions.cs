using Microsoft.EntityFrameworkCore;
using Pdbc.Music.Domain.Model;

namespace Pdbc.Music.Data.Extensions
{
    public static class EnsureDataSeedExtensions
    {
        public static void EnsureSeedData(this MusicDbContext context)
        {
            
        }

        public static void SetupInitialData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().HasData(
                new ArtistBuilder().WithName("U2").Build(),
                new ArtistBuilder().WithName("Bon Jovi").Build()
                );

            modelBuilder.Entity<Genre>().HasData(
                new ArtistBuilder().WithName("Classic").Build(),
                new ArtistBuilder().WithName("Rock").Build()
            );
        }
    }
}