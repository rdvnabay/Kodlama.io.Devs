using Core.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;
namespace Persistence.Contexts;

public sealed class ApplicationDbContext : ProjectDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration) : base(options,configuration){ }


    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }
    public DbSet<Technology> Technologies { get; set; }
}
