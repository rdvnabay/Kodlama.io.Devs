namespace Persistence.Configurations;

public class SocialMediaAccountEntityConfiguration : IEntityTypeConfiguration<SocialMediaAccount>
{
    public void Configure(EntityTypeBuilder<SocialMediaAccount> builder)
    {
        //Seed Data
        int id = 1;
        int developerId = 1;

        builder.HasData(new Faker<SocialMediaAccount>("tr")
            .RuleFor(s => s.Id, f => id++)
            .RuleFor(s => s.DeveloperId, f => developerId++)
            .RuleFor(s => s.Website, f => "Github")
            .RuleFor(s => s.Link, f => $"www.github.com/{f.Internet.UserName()}")
            .Generate(10));
    }
}
