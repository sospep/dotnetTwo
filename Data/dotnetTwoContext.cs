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

        public DbSet<dotnetTwo.Models.Comment> Comment { get; set; }
        // public DbSet<Comment> Comment { get; set; }
 
    }
}