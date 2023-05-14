using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using bugops.Areas.Identity.Data;
using bugops.Common;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("BugopsDbContextConnection") ?? throw new InvalidOperationException("Connection string 'BugopsDbContextConnection' not found.");

builder.Services.AddDbContext<BugopsDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddDefaultIdentity<BugopsUser>(options => options.SignIn.RequireConfirmedAccount = false).AddRoles<IdentityRole>().AddEntityFrameworkStores<BugopsDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

#region Authorization
AddAuthorizationPolicies(builder.Services);
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();

void AddAuthorizationPolicies(IServiceCollection services) {
    services.AddAuthorization(options => {
        options.AddPolicy(Constants.Policies.RequireAdministrator, policy => policy.RequireRole(Constants.Roles.Administrator));
    });
}
