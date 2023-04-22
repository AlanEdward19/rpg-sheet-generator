using Microsoft.EntityFrameworkCore;
using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;
using RPG.SheetGenerator.Infrastructure.Context;

namespace RPG.SheetGenerator.Application.Commands.CreateUpdateItem;

public class CreateUpdateItemCommandHandler: ICommandHandler
{
    private readonly IRepository<Item> _repository;
    private readonly DbSet<Item> _items;

    public CreateUpdateItemCommandHandler(IRepository<Item> repository, RSGDbContext dbContext)
    {
        _repository = repository;
        _items = dbContext.Set<Item>();
    }

    public async Task Insert(ICommand command)
    {
        var model = command as CreateUpdateItemCommand;

        Item item = new()
        {
            Name = model.Name,
            Description = model.Description,
            TypeId = model.TypeId
        };

        await _repository.AddAsync(item);
    }

    public async Task Update(ICommand command, int id)
    {
        var model = command as CreateUpdateItemCommand;

        Item itemDb = await _items.Where(x => x.Id.Equals(id)).FirstOrDefaultAsync();

        itemDb.Description = model.Description;
        itemDb.Name = model.Name;
        itemDb.TypeId = model.TypeId;

        await _repository.UpdateAsync(itemDb, id);
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