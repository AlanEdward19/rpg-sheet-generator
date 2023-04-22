using Microsoft.EntityFrameworkCore;
using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;
using RPG.SheetGenerator.Infrastructure.Context;

namespace RPG.SheetGenerator.Application.Commands.CreateUpdateLanguage;

public class CreateUpdateLanguageCommandHandler : ICommandHandler
{

    private readonly IRepository<Language> _repository;
    private readonly DbSet<Language> _languages;

    public CreateUpdateLanguageCommandHandler(IRepository<Language> repository, RSGDbContext dbContext)
    {
        _repository = repository;
        _languages = dbContext.Set<Language>();
    }

    public async Task Insert(ICommand command)
    {
        var model = command as CreateUpdateLanguageCommand;

        Language language = new()
        {
            Name = model.Name,
            BackgroundId = model.BackgroundId,
            RaceId = model.RaceId
        };

        await _repository.AddAsync(language);
    }

    public async Task Update(ICommand command, int id)
    {
        var model = command as CreateUpdateLanguageCommand;

        Language languageDb = await _languages.Where(x => x.Id.Equals(id)).FirstOrDefaultAsync();

        languageDb.BackgroundId = model.BackgroundId;
        languageDb.RaceId = model.RaceId;
        languageDb.Name = model.Name;

        await _repository.UpdateAsync(languageDb, id);
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