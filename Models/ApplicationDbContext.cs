using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SiteInfomatiomnDetails> SiteInfomatiomnDetails { get; set; }
        public DbSet<Siteinfo> Siteinfo { get; set; }

    }
}
