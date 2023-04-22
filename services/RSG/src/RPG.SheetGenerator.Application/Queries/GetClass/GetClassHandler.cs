using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;

namespace RPG.SheetGenerator.Application.Queries.GetClass;

public class GetClassHandler : IQueryHandler<Class>
{
    private readonly IRepository<Class> _repository;

    public GetClassHandler(IRepository<Class> repository)
    {
        _repository = repository;
    }
    public async Task<List<Class>> GetAll() => await _repository.GetAll();

    public async Task<Class> GetById(int id) => await _repository.GetById(id);

    public Task<Class> GetById(Guid id)
    {
        throw new NotImplementedException();
    }
}