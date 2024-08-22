using Microsoft.EntityFrameworkCore;

namespace AppDatabase.Data
{
    public class BlazorAppContext : DbContext
    {
        public BlazorAppContext (DbContextOptions<BlazorAppContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Visitor> Visitor { get; set; } = default!;
    }
}
