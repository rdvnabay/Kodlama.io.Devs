using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;
namespace Persistence.Contexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration) : base(options)
    {
        Configuration = configuration;
    }

    protected IConfiguration Configuration { get; set; }

    //DbSets
    public DbSet<Developer> Developers { get; set; }
    public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }
    public DbSet<SocialMediaAccount> SocialMediaAccounts { get; set; }
    public DbSet<Technology> Technologies { get; set; }

    public DbSet<User> User { get; set; }
    public DbSet<OperationClaim> OperationClaims { get; set; }
    public DbSet<UserOperationClaim> UserOperationClaims { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
         => modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            base.OnConfiguring(optionsBuilder
                .UseSqlServer(Configuration.GetConnectionString("KodlamaIO"))
                .EnableSensitiveDataLogging());      
    }
}
