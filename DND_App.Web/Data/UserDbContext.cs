using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace DND_App.Web.Data
{
    public class UserDbContext : IdentityDbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("UserAuthSchema");
            base.OnModelCreating(modelBuilder);

            var adminRoleId = "785d5a0a-24a4-40ec-a98b-95e5b4bf43ad";
            var dungeonMasterRoleId = "bd0c279f-d8df-4e39-add7-b33aa79f7cdf";
            var userRoleId = "1d65ffd2-ee1e-483c-9f02-9d0f12ff6721";

            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "Admin",
                    Id = adminRoleId,
                    ConcurrencyStamp = adminRoleId
                },
                new IdentityRole
                {
                    Name = "DM",
                    NormalizedName = "DM",
                    Id = dungeonMasterRoleId,
                    ConcurrencyStamp = dungeonMasterRoleId
                },
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "User",
                    Id = userRoleId,
                    ConcurrencyStamp = userRoleId
                }
            };

            modelBuilder.Entity<IdentityRole>().HasData(roles);

            var adminId = "59c21724-793c-4cb1-9438-dec6213c808b";
            var adminUser = new IdentityUser
            {
                UserName = "rickthestick",
                Email = "dadsathome1@gmail.com",
                NormalizedEmail = "dadsathome1@gmail.com".ToUpper(),
                NormalizedUserName = "rickthestick".ToUpper(),
                Id = adminId
            };

            adminUser.PasswordHash = new PasswordHasher<IdentityUser>()
                .HashPassword(adminUser, "$$RickTheStick11");

            modelBuilder.Entity<IdentityUser>().HasData(adminUser);

            var adminRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = adminId
                },
                new IdentityUserRole<string>
                {
                    RoleId = dungeonMasterRoleId,
                    UserId = adminId
                },
                new IdentityUserRole<string>
                {
                    RoleId = userRoleId,
                    UserId= adminId
                }
            };

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(adminRoles);
        }
    }
}

