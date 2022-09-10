using Application.Services.Repositories;
using Core.Persistence.Repositories.Base;

namespace Persistence.Repositories;
public class ProgrammingLanguageRepository : EfRepositoryBase<ApplicationDbContext, ProgrammingLanguage>,IProgrammingLanguageRepository
{
    public ProgrammingLanguageRepository(ApplicationDbContext context) : base(context) { }
}

