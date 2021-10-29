using Microsoft.EntityFrameworkCore;
using RestAPI.DatabaseSchema;

namespace RestAPI.Context
{
    public class LoginContext : DbContext
    {
        public LoginContext(DbContextOptions<LoginContext> options)
            : base(options)
        {
        }

        public DbSet<User> UserItems { get; set; }
    }
}