using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;
using Attribute = RPG.SheetGenerator.Core.Entities.Attribute;

namespace RPG.SheetGenerator.Application.Queries.GetAttribute;

public class GetAttributeHandler : IQueryHandler<Attribute>
{
    private readonly IRepository<Attribute> _repository;

    public GetAttributeHandler(IRepository<Attribute> repository)
    {
        _repository = repository;
    }
    public async Task<List<Attribute>> GetAll()
    {
        return await _repository.GetAll();
    }

    public async Task<Attribute> GetById(int id)
    {
        return await _repository.GetById(id);
    }

    public Task<Attribute> GetById(Guid id)
    {
        throw new NotImplementedException();
    }
}