using Microsoft.EntityFrameworkCore;
using RestAPI.Models;

namespace RestAPI.Context
{
    public class CampaignContext : DbContext
    {
        public CampaignContext(DbContextOptions<LoginContext> options)
            : base(options)
        {
        }

        public DbSet<Campaign> CampaignItems { get; set; }
    }
}