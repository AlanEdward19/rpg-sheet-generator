using Microsoft.EntityFrameworkCore;
using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;
using RPG.SheetGenerator.Infrastructure.Context;

namespace RPG.SheetGenerator.Application.Commands.CreateUpdateProficiency;

public class CreateUpdateProficiencyCommandHandler : ICommandHandler
{
    private readonly IRepository<Proficiency> _repository;
    private readonly DbSet<Proficiency> _proficiencies;

    public CreateUpdateProficiencyCommandHandler(IRepository<Proficiency> repository, RSGDbContext dbContext)
    {
        _repository = repository;
        _proficiencies = dbContext.Set<Proficiency>();
    }

    public async Task Insert(ICommand command)
    {
        var model = command as CreateUpdateProficiencyCommand;

        Proficiency proficiency = new()
        {
            Name = model.Name,
            AttributeId = model.AttributeId,
            Description = model.Description
        };

        await _repository.AddAsync(proficiency);
    }

    public async Task Update(ICommand command, int id)
    {
        var model = command as CreateUpdateProficiencyCommand;

        Proficiency proficiencyDb = await _proficiencies.Where(x => x.Id.Equals(id)).FirstOrDefaultAsync();

        proficiencyDb.Name = model.Name;
        proficiencyDb.AttributeId = model.AttributeId;
        proficiencyDb.Description = model.Description;

        await _repository.UpdateAsync(proficiencyDb, id);
    }

    public Task Update(ICommand command, Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task Delete(int id) => await _repository.DeleteById(id);

    public Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}