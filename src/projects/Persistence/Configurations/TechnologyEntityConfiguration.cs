namespace Persistence.Configurations;

public class TechnologyEntityConfiguration : IEntityTypeConfiguration<Technology>
{
    public void Configure(EntityTypeBuilder<Technology> builder)
    {
        //Seed Data
        builder.HasData(new List<Technology>
        {
            new() { Id = 1, Name = "Asp.Net", ProgrammingLanguageId = 1 },
            new() { Id = 2, Name = "Blazor", ProgrammingLanguageId = 1 },
            new() { Id = 3, Name = ".Net MAUI", ProgrammingLanguageId = 1 },
            new() { Id = 4, Name = "Spring", ProgrammingLanguageId = 2 },
            new() { Id = 5, Name = "JSP", ProgrammingLanguageId = 2 },
            new() { Id = 6, Name = "Gin", ProgrammingLanguageId = 3 },
            new() { Id = 7, Name = "Django", ProgrammingLanguageId = 4 },
            new() { Id = 8, Name = "Flask", ProgrammingLanguageId = 4 },
            new() { Id = 9, Name = "Angular", ProgrammingLanguageId = 5 },
            new() { Id = 10, Name = "Vue", ProgrammingLanguageId = 5 }
        });
    }
}
