using Application.Services.Repositories;

namespace Persistence.Repositories;
public class ProgrammingLanguageRepository : EfRepositoryBase<ApplicationDbContext, ProgrammingLanguage>,IProgrammingLanguageRepository
{
    public ProgrammingLanguageRepository(ApplicationDbContext context) : base(context) { }
}

