using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;

namespace RPG.SheetGenerator.Application.Queries.GetRace;

public class GetRaceHandler : IQueryHandler<Race>
{
    private readonly IRepository<Race> _repository;

    public GetRaceHandler(IRepository<Race> repository)
    {
        _repository = repository;
    }

    public async Task<List<Race>> GetAll() => await _repository.GetAll();
    public async Task<Race> GetById(int id) => await _repository.GetById(id);

    public Task<Race> GetById(Guid id)
    {
        throw new NotImplementedException();
    }
}