using IdentityandDataProtection.Entities;
using Microsoft.EntityFrameworkCore;

namespace IdentityandDataProtection.Context
{
    public class IdentityandDataProtectionDbContext : DbContext
    {
        public IdentityandDataProtectionDbContext(DbContextOptions<IdentityandDataProtectionDbContext> options) : base (options )
            { }

        public DbSet<UserEntity> Users => Set<UserEntity>();
    }
}
