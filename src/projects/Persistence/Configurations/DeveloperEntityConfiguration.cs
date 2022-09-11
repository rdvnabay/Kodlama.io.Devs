using Core.Security.Helpers;
namespace Persistence.Configurations;

public class DeveloperEntityConfiguration : IEntityTypeConfiguration<Developer>
{
    public void Configure(EntityTypeBuilder<Developer> builder)
    {
        //Seed Data
        int id = 1;
        HashingHelper.CreatePasswordHash("123456", out var passwordSalt, out var passwordHash);

        builder.HasData(new Faker<Developer>("tr")
            .RuleFor(u => u.Id, f => id++)
            .RuleFor(u => u.FirstName, f => f.Person.FirstName)
            .RuleFor(u => u.LastName, f => f.Person.LastName)
            .RuleFor(u => u.Email, f => f.Person.Email)
            .RuleFor(u => u.Status, f => f.Random.Bool())
            .RuleFor(u => u.PasswordHash, f => passwordHash)
            .RuleFor(u => u.PasswordSalt, f => passwordSalt)
            .Generate(10));
    }
}
