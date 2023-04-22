using Microsoft.EntityFrameworkCore;
using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;
using RPG.SheetGenerator.Infrastructure.Context;
using Attribute = RPG.SheetGenerator.Core.Entities.Attribute;

namespace RPG.SheetGenerator.Application.Commands.CreateUpdateAttribute;

public class CreateUpdateAttributeCommandHandler : ICommandHandler
{
    private readonly IRepository<Attribute> _repository;
    private readonly DbSet<Character> _dbSet;

    public CreateUpdateAttributeCommandHandler(IRepository<Attribute> repository, RSGDbContext dbContext)
    {
        _repository = repository;
        _dbSet = dbContext.Set<Character>();
    }

    public async Task Insert(ICommand command)
    {
        var model = command as CreateUpdateAttributeCommand;

        var characterDb = model.CharacterIds is null
            ? null
            : await _dbSet.Where(x => model.CharacterIds.Contains(x.Id)).ToListAsync();

        Attribute attribute = new()
        {
            Name = model.Name,
            Description = model.Description,
            Value = model.Value,
            Characters = characterDb
        };

        await _repository.AddAsync(attribute);
    }

    public async Task Update(ICommand command, int id)
    {
        var model = command as CreateUpdateAttributeCommand;

        var characterDb = model.CharacterIds is null
            ? null
            : await _dbSet.Where(x => model.CharacterIds.Contains(x.Id)).ToListAsync();

        Attribute attribute = new()
        {
            Name = model.Name,
            Description = model.Description,
            Value = model.Value,
            Characters = characterDb
        };

        await _repository.UpdateAsync(attribute, id);
    }

    public async Task Delete(int id) => await _repository.DeleteById(id);

    public Task Update(ICommand command, Guid id)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}