using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;

namespace RPG.SheetGenerator.Application.Queries.GetCharacter;

public class GetCharacterHandler : IQueryHandler<Character>
{
    private readonly IRepository<Character> _repository;

    public GetCharacterHandler(IRepository<Character> repository)
    {
        _repository = repository;
    }
    public async Task<List<Character>> GetAll() => await _repository.GetAll();

    public Task<Character> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Character> GetById(Guid id) => await _repository.GetById(id);
}