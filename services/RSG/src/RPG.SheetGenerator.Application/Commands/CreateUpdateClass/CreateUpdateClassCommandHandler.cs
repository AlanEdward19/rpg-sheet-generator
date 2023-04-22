using Microsoft.EntityFrameworkCore;
using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;
using RPG.SheetGenerator.Infrastructure.Context;

namespace RPG.SheetGenerator.Application.Commands.CreateUpdateClass;

public class CreateUpdateClassCommandHandler : ICommandHandler
{
    private readonly IRepository<Class> _repository;
    private readonly DbSet<Class> _class;

    public CreateUpdateClassCommandHandler(IRepository<Class> repository, RSGDbContext dbContext)
    {
        _repository = repository;
        _class = dbContext.Set<Class>();
    }

    public async Task Insert(ICommand command)
    {
        var model = command as CreateUpdateClassCommand;

        Class classe = new()
        {
            Name = model.Name,
            Description = model.Description,
            LifeAmount = model.LifeAmount
        };

        await _repository.AddAsync(classe);
    }

    public async Task Update(ICommand command, int id)
    {
        var model = command as CreateUpdateClassCommand;

        Class classeDb = await _class.Where(x => x.Id.Equals(id)).FirstOrDefaultAsync();

        classeDb.Name = model.Name;
        classeDb.Description = model.Description;
        classeDb.LifeAmount = model.LifeAmount;

        await _repository.UpdateAsync(classeDb, id);
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