using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;

namespace RPG.SheetGenerator.Application.Queries.GetItem;

public class GetItemHandler : IQueryHandler<Item>
{
    private readonly IRepository<Item> _repository;

    public GetItemHandler(IRepository<Item> repository)
    {
        _repository = repository;
    }

    public async Task<List<Item>> GetAll() => await _repository.GetAll();
    public async Task<Item> GetById(int id) => await _repository.GetById(id);

    public Task<Item> GetById(Guid id)
    {
        throw new NotImplementedException();
    }
}