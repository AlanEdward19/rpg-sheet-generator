using Microsoft.EntityFrameworkCore;
using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;
using System;
using RPG.SheetGenerator.Infrastructure.Context;
using Attribute = RPG.SheetGenerator.Core.Entities.Attribute;

namespace RPG.SheetGenerator.Application.Commands.CreateUpdateCharacter;

public class CreateUpdateCharacterCommandHandler : ICommandHandler
{
    private readonly IRepository<Character> _repository;

    private readonly DbSet<Alignment> _alignment;
    private readonly DbSet<Background> _background;
    private readonly DbSet<Campaign> _campaign;
    private readonly DbSet<Class> _class;
    private readonly DbSet<Language> _language;
    private readonly DbSet<Player> _player;
    private readonly DbSet<Proficiency> _proficiency;
    private readonly DbSet<Race> _race;
    private readonly DbSet<Character> _character;
    private readonly DbSet<Item> _item;

    public CreateUpdateCharacterCommandHandler(IRepository<Character> repository, RSGDbContext dbContext)
    {
        _repository = repository;
        _alignment = dbContext.Set<Alignment>();
        _background = dbContext.Set<Background>();
        _campaign = dbContext.Set<Campaign>();
        _class = dbContext.Set<Class>();
        _language = dbContext.Set<Language>();
        _player = dbContext.Set<Player>();
        _proficiency = dbContext.Set<Proficiency>();
        _race = dbContext.Set<Race>();
        _character = dbContext.Set<Character>();
        _item = dbContext.Set<Item>();
    }

    public async Task Insert(ICommand command)
    {
        var model = command as CreateCharacterCommand;

        var alignmentDb = await _alignment.Where(x => x.Id.Equals(model.AlignmentId)).FirstOrDefaultAsync();
        var backgroundDb = await _background.Where(x => x.Id.Equals(model.BackgroundId)).FirstOrDefaultAsync();

        var campaignDb = model.CampaignId is null
            ? null
            : await _campaign.Where(x => x.CampaignId.Equals(model.CampaignId)).FirstOrDefaultAsync();

        var itemsDb = model.ItemsId is null
            ? null
            : await _item.Where(x => model.ItemsId.Contains(x.Id)).ToListAsync();

        var classDb = await _class.Where(x => model.ClassId.Equals(x.Id)).FirstOrDefaultAsync();
        var playerDb = await _player.Where(x => x.Id.Equals(model.PlayerId)).FirstOrDefaultAsync();
        var proficienciesDb = await _proficiency.Where(x => model.ProficienciesId.Contains(x.Id)).ToListAsync();
        var raceDb = await _race.Where(x => x.Id.Equals(model.RaceId)).FirstOrDefaultAsync();
        var languagesDb = await _language.Where(x => model.LanguagesId.Contains(x.Id)).ToListAsync();

        Character character = new()
        {
            NickName = model.NickName,
            Age = model.Age,
            ArmorClass = model.ArmorClass,
            Bonds = model.Bonds,
            Flaws = model.Flaws,
            Ideals = model.Ideals,
            PersonalityTraits = model.PersonalityTraits,
            Alignment = alignmentDb,
            Background = backgroundDb,
            Campaign = campaignDb,
            Classes = new List<Class>(){ classDb },
            Player = playerDb,
            Race = raceDb
        };

        character.NewCharacter();

        foreach (var language in languagesDb)
        {
            character.Languages.Append(language);
        }

        foreach (var proficiency in proficienciesDb)
        {
            character.Proficiencies.Append(proficiency);
        }

        foreach (var item in itemsDb)
        {
            character.Inventory.AddItem(item);
        }

        await _repository.AddAsync(character);
    }

    public Task Update(ICommand command, int id)
    {
        throw new NotImplementedException();
    }

    public async Task Update(ICommand command, Guid id)
    {
        var model = command as UpdateCharacterCommand;

        var alignmentDb = await _alignment.Where(x => x.Id.Equals(model.AlignmentId)).FirstOrDefaultAsync();

        var campaignDb = model.CampaignId is null
            ? null
            : await _campaign.Where(x => x.CampaignId.Equals(model.CampaignId)).FirstOrDefaultAsync();

        var itemsDb = model.ItemsId is null
            ? null
            : await _item.Where(x => model.ItemsId.Contains(x.Id)).ToListAsync();

        var classesDb = await _class.Where(x => model.ClassesId.Contains(x.Id)).ToListAsync();
        var languagesDb = await _language.Where(x => model.LanguagesId.Contains(x.Id)).ToListAsync();
        var proficienciesDb = await _proficiency.Where(x => model.ProficienciesId.Contains(x.Id)).ToListAsync();

        Character character = await _character.Where(x => x.Id.Equals(id)).FirstOrDefaultAsync();

        character.NickName = model.NickName;
        character.Age = model.Age;
        character.ArmorClass = model.ArmorClass;
        character.Bonds = model.Bonds;
        character.Flaws = model.Flaws;
        character.Ideals = model.Ideals;
        character.PersonalityTraits = model.PersonalityTraits;
        character.Speed = model.Speed;
        character.Alignment = alignmentDb;
        character.Campaign = campaignDb;

        foreach (var classe in classesDb)
        {
            character.Classes.Append(classe);
        }

        foreach (var language in languagesDb)
        {
            character.Languages.Append(language);
        }

        foreach (var proficiency in proficienciesDb)
        {
            character.Proficiencies.Append(proficiency);
        }

        foreach (var item in itemsDb)
        {
            character.Inventory.AddItem(item);
        }

        await _repository.UpdateAsync(character, id);
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public async Task Delete(Guid id) => await _repository.DeleteById(id);
}