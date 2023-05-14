using bugops.Areas.Identity.Data;
using bugops.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bugops.Areas.Identity.Data;

public class BugopsDbContext : IdentityDbContext<BugopsUser> {
    public BugopsDbContext(DbContextOptions<BugopsDbContext> options)
        : base(options) {
    }

    protected override void OnModelCreating(ModelBuilder builder) {
        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new BugopsUserEntityConfiguration());

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole { Id = "1", Name = Constants.Roles.Administrator, NormalizedName = Constants.Roles.Administrator.ToUpper() },
            new IdentityRole { Id = "2", Name = Constants.Roles.Developer, NormalizedName = Constants.Roles.Developer.ToUpper() },
            new IdentityRole { Id = "3", Name = Constants.Roles.User, NormalizedName = Constants.Roles.User.ToUpper() },
            new IdentityRole { Id = "4", Name = Constants.Roles.Demo, NormalizedName = Constants.Roles.Demo.ToUpper() }
        );

        // WARNING: This is VERY insecure, this app is meant for demo purposes
        BugopsUser dummyUser = new BugopsUser();
        string defaultPasswordHash = new PasswordHasher<BugopsUser>().HashPassword(dummyUser, "password");

        builder.Entity<BugopsUser>().HasData(
            new BugopsUser {
                Id = "1",
                UserName = "administrator@example.com",
                NormalizedUserName = "ADMINISTRATOR@EXAMPLE.COM",
                Email = "administrator@example.com",
                NormalizedEmail = "ADMINISTRATOR@EXAMPLE.COM",
                EmailConfirmed = true,
                FirstName = "Administrator",
                LastName = "Administrator",
                PasswordHash = defaultPasswordHash
            },
            new BugopsUser {
                Id = "2",
                UserName = "developer@example.com",
                NormalizedUserName = "DEVELOPER@EXAMPLE.COM",
                Email = "developer@example.com",
                NormalizedEmail = "DEVELOPER@EXAMPLE.COM",
                EmailConfirmed = true,
                FirstName = "Developer",
                LastName = "Developer",
                PasswordHash = defaultPasswordHash
            },
            new BugopsUser {
                Id = "3",
                UserName = "user@example.com",
                NormalizedUserName = "USER@EXAMPLE.COM",
                Email = "user@example.com",
                NormalizedEmail = "USER@EXAMPLE.COM",
                EmailConfirmed = true,
                FirstName = "User",
                LastName = "User",
                PasswordHash = defaultPasswordHash
            },
            new BugopsUser {
                Id = "4",
                UserName = "demo@example.com",
                NormalizedUserName = "DEMO@EXAMPLE.COM",
                Email = "demo@example.com",
                NormalizedEmail = "DEMO@EXAMPLE.COM",
                EmailConfirmed = true,
                FirstName = "Demo",
                LastName = "Demo",
                PasswordHash = defaultPasswordHash
            }
        );

        // Assign users to roles
        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string> { UserId = "1", RoleId = "1" },
            new IdentityUserRole<string> { UserId = "2", RoleId = "2" },
            new IdentityUserRole<string> { UserId = "3", RoleId = "3" },
            new IdentityUserRole<string> { UserId = "4", RoleId = "4" }
        );
    }
}

public class BugopsUserEntityConfiguration : IEntityTypeConfiguration<BugopsUser> {
    public void Configure(EntityTypeBuilder<BugopsUser> builder) {
        builder.Property(x => x.FirstName).HasMaxLength(255);
        builder.Property(x => x.LastName).HasMaxLength(255);
    }
}