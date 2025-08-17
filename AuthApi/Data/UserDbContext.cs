using AuthApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuthApi.Data
{
    public class UserDbContext(DbContextOptions<UserDbContext> options) : DbContext(options)
    {
        public DbSet<User> users { get; set; }
    }
}
