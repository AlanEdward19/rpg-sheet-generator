using Microsoft.EntityFrameworkCore;
using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;
using RPG.SheetGenerator.Infrastructure.Context;

namespace RPG.SheetGenerator.Application.Commands.CreateUpdateBackground;

public class CreateUpdateBackgroundCommandHandler : ICommandHandler
{
    private readonly IRepository<Background> _repository;
    private readonly DbSet<Item> _items;
    private readonly DbSet<Language> _languages;

    public CreateUpdateBackgroundCommandHandler(IRepository<Background> repository, RSGDbContext dbContext)
    {
        _repository = repository;
        _items = dbContext.Set<Item>();
        _languages = dbContext.Set<Language>();
    }
    public async Task Insert(ICommand command)
    {
        var model = command as CreateUpdateBackgroundCommand;

        var itemsDb = model.BackgroundItems is null
            ? null
            : await _items.Where(x => model.BackgroundItems.Contains(x.Id)).ToListAsync();

        var languagesDb = model.BackgroundLanguages is null
            ? null
            : await _languages.Where(x => model.BackgroundLanguages.Contains(x.Id)).ToListAsync();

        Background background = new()
        {
            Name = model.Name,
            Description = model.Description,
            BackgroundItems = itemsDb,
            BackgroundLanguages = languagesDb
        };

        await _repository.AddAsync(background);
    }

    public async Task Update(ICommand command, int id)
    {
        var model = command as CreateUpdateBackgroundCommand;

        var itemsDb = model.BackgroundItems is null
            ? null
            : await _items.Where(x => model.BackgroundItems.Contains(x.Id)).ToListAsync();

        var languagesDb = model.BackgroundLanguages is null
            ? null
            : await _languages.Where(x => model.BackgroundLanguages.Contains(x.Id)).ToListAsync();

        Background background = new()
        {
            Name = model.Name,
            Description = model.Description,
            BackgroundItems = itemsDb,
            BackgroundLanguages = languagesDb
        };

        await _repository.UpdateAsync(background, id);
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