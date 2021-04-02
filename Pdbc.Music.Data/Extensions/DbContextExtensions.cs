using Microsoft.EntityFrameworkCore;

namespace Pdbc.Music.Data.Extensions
{
    public static class DbContextExtensions
    {
        public static void SafeReload(this DbContext context, object entity)
        {
            context.Entry(entity).Reload();
        }
    }
}