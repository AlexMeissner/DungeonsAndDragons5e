using Microsoft.EntityFrameworkCore;

namespace RestAPI.DatabaseSchema
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Campaign> Campaign { get; set; }
        public DbSet<UserCampaignMapping> UserCampaignMapping { get; set; }
    }
}