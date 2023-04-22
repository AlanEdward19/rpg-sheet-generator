using Microsoft.EntityFrameworkCore;
using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;
using RPG.SheetGenerator.Infrastructure.Context;

namespace RPG.SheetGenerator.Application.Commands.CreateUpdateRace;

public class CreateUpdateRaceCommandHandler : ICommandHandler
{
    private readonly IRepository<Race> _repository;
    private readonly DbSet<Race> _races;
    private readonly DbSet<Language> _languages;

    public CreateUpdateRaceCommandHandler(IRepository<Race> repository, RSGDbContext dbContext)
    {
        _repository = repository;
        _races = dbContext.Set<Race>();
        _languages = dbContext.Set<Language>();
    }

    public async Task Insert(ICommand command)
    {
        var model = command as CreateUpdateRaceCommand;
        var languagesDb = await _languages.Where(x => model.LanguageId.Contains(x.Id)).ToListAsync();

        Race race = new()
        {
            Name = model.Name,
            Speed = model.Speed,
            RaceLanguages = languagesDb
        };

        await _repository.AddAsync(race);
    }

    public async Task Update(ICommand command, int id)
    {
        var model = command as CreateUpdateRaceCommand;
        var languagesDb = await _languages.Where(x => model.LanguageId.Contains(x.Id)).ToListAsync();

        Race raceDb = await _races.Where(x => x.Id.Equals(id)).FirstOrDefaultAsync();

        raceDb.Name = model.Name;
        raceDb.Speed = model.Speed;
        raceDb.RaceLanguages = languagesDb;

        await _repository.UpdateAsync(raceDb, id);
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