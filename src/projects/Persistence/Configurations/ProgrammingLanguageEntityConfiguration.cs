namespace Persistence.Configurations;

public class ProgrammingLanguageEntityConfiguration : IEntityTypeConfiguration<ProgrammingLanguage>
{
    public void Configure(EntityTypeBuilder<ProgrammingLanguage> builder)
    {
        //Seed Data
        builder.HasData(new List<ProgrammingLanguage>
        {
            new() { Id = 1, Name = "C#" },
            new() { Id = 2, Name = "Java" },
            new() { Id = 3, Name = "Go" },
            new() { Id = 4, Name = "Python" },
            new() { Id = 5, Name = "JavaScript" }
        });
    }
}
