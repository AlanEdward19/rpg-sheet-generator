using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;

namespace RPG.SheetGenerator.Application.Queries.GetAlignment;

public class GetAlignmentHandler : IQueryHandler<Alignment>
{
    private readonly IRepository<Alignment> _repository;

    public GetAlignmentHandler(IRepository<Alignment> repository)
    {
        _repository = repository;
    }

    public async Task<List<Alignment>> GetAll()
    {
        return await _repository.GetAll();
    }

    public async Task<Alignment> GetById(int id)
    {
        return await _repository.GetById(id);
    }

    public Task<Alignment> GetById(Guid id)
    {
        throw new NotImplementedException();
    }
}