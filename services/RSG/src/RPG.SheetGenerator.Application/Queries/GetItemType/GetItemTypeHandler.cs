using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;

namespace RPG.SheetGenerator.Application.Queries.GetItemType;

public class GetItemTypeHandler : IQueryHandler<ItemType>
{
    private readonly IRepository<ItemType> _repository;

    public GetItemTypeHandler(IRepository<ItemType> repository)
    {
        _repository = repository;
    }

    public async Task<List<ItemType>> GetAll() => await _repository.GetAll();
    public async Task<ItemType> GetById(int id) => await _repository.GetById(id);

    public Task<ItemType> GetById(Guid id)
    {
        throw new NotImplementedException();
    }
}