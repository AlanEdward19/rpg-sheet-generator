using Microsoft.EntityFrameworkCore;
using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;
using RPG.SheetGenerator.Infrastructure.Context;

namespace RPG.SheetGenerator.Application.Commands.CreateUpdateItemType;

public class CreateUpdateItemTypeCommandHandler : ICommandHandler
{
    private readonly IRepository<ItemType> _repository;
    private readonly DbSet<ItemType> _items;

    public CreateUpdateItemTypeCommandHandler(IRepository<ItemType> repository, RSGDbContext dbContext)
    {
        _repository = repository;
        _items = dbContext.Set<ItemType>();
    }

    public async Task Insert(ICommand command)
    {
        var model = command as CreateUpdateItemTypeCommand;

        ItemType itemType = new()
        {
            Name = model.Name
        };

        await _repository.AddAsync(itemType);
    }

    public async Task Update(ICommand command, int id)
    {
        var model = command as CreateUpdateItemTypeCommand;

        ItemType itemTypeDb = await _items.Where(x => x.Id.Equals(id)).FirstOrDefaultAsync();

        itemTypeDb.Name = model.Name;

        await _repository.UpdateAsync(itemTypeDb, id);
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