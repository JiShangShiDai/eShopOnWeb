using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Identity
{
    /// <summary>
    /// current tooling requires launchable host to use migrations.
    /// Dummy MigrationsConcole project handles this requirement.
    /// To add migrations use:
    /// dotnet ef --startup-project ../MigrationsConcole migrations add {name}
    /// To apply migrations use:
    /// dotnet ef --startup-project ../MigrationsConsole database update
    /// </summary>
    public class AppIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppIdentityDbContext()
        {

        }

        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        //// 因为使用无参构造器，所以需要自带链接字符串
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=localhost;Integrated Security=true;Initial Catalog=Microsoft.eShopOnWeb.Identity");
        //}
    }

    public class ApplicationUser : IdentityUser
    {
    }

}
