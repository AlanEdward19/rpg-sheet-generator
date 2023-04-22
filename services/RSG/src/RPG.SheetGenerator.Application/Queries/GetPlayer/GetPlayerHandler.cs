using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;

namespace RPG.SheetGenerator.Application.Queries.GetPlayer;

public class GetPlayerHandler : IQueryHandler<Player>
{
    private readonly IRepository<Player> _repository;

    public GetPlayerHandler(IRepository<Player> repository)
    {
        _repository = repository;
    }
    public async Task<List<Player>> GetAll() => await _repository.GetAll();

    public Task<Player> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Player> GetById(Guid id) => await _repository.GetById(id);
}