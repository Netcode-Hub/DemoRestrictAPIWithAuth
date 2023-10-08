using DemoRestrictAPIWithAuth.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoRestrictAPIWithAuth.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<TokenInfo> TokenInfo { get; set; }
    }
}
