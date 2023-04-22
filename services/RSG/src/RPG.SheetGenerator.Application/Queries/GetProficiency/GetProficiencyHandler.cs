using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;

namespace RPG.SheetGenerator.Application.Queries.GetProficiency;

public class GetProficiencyHandler : IQueryHandler<Proficiency>
{
    private readonly IRepository<Proficiency> _repository;

    public GetProficiencyHandler(IRepository<Proficiency> repository)
    {
        _repository = repository;
    }

    public async Task<List<Proficiency>> GetAll() => await _repository.GetAll();
    public async Task<Proficiency> GetById(int id) => await _repository.GetById(id);

    public Task<Proficiency> GetById(Guid id)
    {
        throw new NotImplementedException();
    }
}