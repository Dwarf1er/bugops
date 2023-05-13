using bugops.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bugops.Areas.Identity.Data;

public class BugopsDbContext : IdentityDbContext<BugopsUser>
{
    public BugopsDbContext(DbContextOptions<BugopsDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new BugopsUserEntityConfiguration());
    }
}

public class BugopsUserEntityConfiguration: IEntityTypeConfiguration<BugopsUser> {
    public void Configure(EntityTypeBuilder<BugopsUser> builder) {
        builder.Property(x => x.FirstName).HasMaxLength(255);
        builder.Property(x => x.LastName).HasMaxLength(255);
    }
}
