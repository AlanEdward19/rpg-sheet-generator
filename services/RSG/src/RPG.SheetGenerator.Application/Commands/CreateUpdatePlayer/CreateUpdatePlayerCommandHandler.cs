using Microsoft.EntityFrameworkCore;
using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;
using RPG.SheetGenerator.Infrastructure.Context;

namespace RPG.SheetGenerator.Application.Commands.CreateUpdatePlayer;

public class CreateUpdatePlayerCommandHandler : ICommandHandler
{
    private readonly IRepository<Player> _repository;
    private readonly DbSet<Player> _players;
    private readonly DbSet<Character> _characters;

    public CreateUpdatePlayerCommandHandler(IRepository<Player> repository, RSGDbContext dbContext)
    {
        _repository = repository;
        _players = dbContext.Set<Player>();
        _characters = dbContext.Set<Character>();
    }

    public async Task Insert(ICommand command)
    {
        var model = command as CreateUpdatePlayerCommand;
        var charactersDb = await _characters.Where(x => model.CharactersId.Contains(x.Id)).ToListAsync();

        Player player = new()
        {
            Name = model.Name,
            Email = model.Email,
            Characters = charactersDb
        };

        await _repository.AddAsync(player);
    }

    public Task Update(ICommand command, int id)
    {
        throw new NotImplementedException();
    }

    public async Task Update(ICommand command, Guid id)
    {
        var model = command as CreateUpdatePlayerCommand;
        var charactersDb = await _characters.Where(x => model.CharactersId.Contains(x.Id)).ToListAsync();

        Player playerDb = await _players.Where(x => x.Id.Equals(id)).FirstOrDefaultAsync();

        playerDb.Name = model.Name;
        playerDb.Email = model.Email;
        playerDb.Characters = charactersDb;

        await _repository.UpdateAsync(playerDb, id);
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public async Task Delete(Guid id) => await _repository.DeleteById(id);
}