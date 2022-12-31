using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Neon.Web.Entities;
using Neon.Web.Entities.Member;
using Neon.Web.Seeds;

namespace Neon.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, Role, Guid, UserClaim, 
        UserRole, UserLogin, RoleClaim, UserToken>, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(CategoriesSeed.Categories);
            builder.Entity<Role>().HasData(RoleSeed.Roles);
            builder.Entity<ApplicationUser>().HasData(AdminSeed.Users);
            builder.Entity<UserRole>().HasData(AdminSeed.UserRole);
            base.OnModelCreating(builder);
        }

        public DbSet<Category> Categories { get; set; }
    }
}