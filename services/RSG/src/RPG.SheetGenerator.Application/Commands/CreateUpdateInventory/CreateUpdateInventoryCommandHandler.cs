using Microsoft.EntityFrameworkCore;
using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;
using RPG.SheetGenerator.Infrastructure.Context;

namespace RPG.SheetGenerator.Application.Commands.CreateUpdateInventory;

public class CreateUpdateInventoryCommandHandler : ICommandHandler
{
    private readonly IRepository<Inventory> _repository;
    private readonly DbSet<Inventory> _inventory;
    private readonly DbSet<Item> _items;

    public CreateUpdateInventoryCommandHandler(IRepository<Inventory> repository, RSGDbContext dbContext)
    {
        _repository = repository;
        _inventory = dbContext.Set<Inventory>();
        _items = dbContext.Set<Item>();
    }

    public async Task Insert(ICommand command)
    {
        var model = command as CreateUpdateInventoryCommand;

        var itensDb = await _items.Where(x => model.ItemsId.Contains(x.Id)).ToListAsync();

        Inventory inventory = new()
        {
            Name = model.Name,
            Items = itensDb,
        };

        await _repository.AddAsync(inventory);
    }

    public Task Update(ICommand command, int id)
    {
        throw new NotImplementedException();
    }

    public Task Update(ICommand command, Guid id)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}