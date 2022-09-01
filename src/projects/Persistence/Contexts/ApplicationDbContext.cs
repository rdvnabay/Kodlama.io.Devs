using Microsoft.EntityFrameworkCore;

namespace Persistence.Contexts;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


    public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }
}
