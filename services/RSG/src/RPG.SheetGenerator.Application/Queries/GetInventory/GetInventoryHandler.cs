using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;

namespace RPG.SheetGenerator.Application.Queries.GetInventory;

public class GetInventoryHandler : IQueryHandler<Inventory>
{
    private readonly IRepository<Inventory> _repository;

    public GetInventoryHandler(IRepository<Inventory> repository)
    {
        _repository = repository;
    }

    public async Task<List<Inventory>> GetAll() => await _repository.GetAll();
    public async Task<Inventory> GetById(int id) => await _repository.GetById(id);
    
    public Task<Inventory> GetById(Guid id)
    {
        throw new NotImplementedException();
    }
}