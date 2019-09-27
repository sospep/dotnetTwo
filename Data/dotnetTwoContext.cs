using Microsoft.EntityFrameworkCore;
using dotnetTwo.Models;

namespace dotnetTwo.Data
{
    public class dotnetTwoContext : DbContext
    {
        public dotnetTwoContext (DbContextOptions<dotnetTwoContext> options)
            : base(options)
        {
        }

        public DbSet<Article> Article { get; set; }
    }
}