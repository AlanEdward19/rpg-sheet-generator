using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;

namespace RPG.SheetGenerator.Application.Queries.GetLanguage;

public class GetLanguageHandler : IQueryHandler<Language>
{
    private readonly IRepository<Language> _repository;

    public GetLanguageHandler(IRepository<Language> repository)
    {
        _repository = repository;
    }

    public async Task<List<Language>> GetAll() => await _repository.GetAll();
    public async Task<Language> GetById(int id) => await _repository.GetById(id);

    public Task<Language> GetById(Guid id)
    {
        throw new NotImplementedException();
    }
}