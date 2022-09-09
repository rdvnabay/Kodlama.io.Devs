using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;
namespace Core.Persistence.Contexts;

public class ProjectDbContext:DbContext
{
    protected IConfiguration Configuration { get; set; }

    public ProjectDbContext(DbContextOptions<ProjectDbContext> options, IConfiguration configuration) : base(options)
    {
        Configuration = configuration;
    }

    public ProjectDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
    {
        Configuration = configuration;
    }

    public DbSet<User> User { get; set; }
    public DbSet<OperationClaim> OperationClaims { get; set; }
    public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
     => modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
}
