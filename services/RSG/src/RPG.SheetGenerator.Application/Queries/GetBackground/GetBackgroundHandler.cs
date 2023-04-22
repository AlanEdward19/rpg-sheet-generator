using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;

namespace RPG.SheetGenerator.Application.Queries.GetBackground;

public class GetBackgroundHandler : IQueryHandler<Background>
{
    private readonly IRepository<Background> _repository;

    public GetBackgroundHandler(IRepository<Background> repository)
    {
        _repository = repository;
    }

    public async Task<List<Background>> GetAll() => await _repository.GetAll();
    public async Task<Background> GetById(int id) => await _repository.GetById(id);

    public Task<Background> GetById(Guid id)
    {
        throw new NotImplementedException();
    }
}