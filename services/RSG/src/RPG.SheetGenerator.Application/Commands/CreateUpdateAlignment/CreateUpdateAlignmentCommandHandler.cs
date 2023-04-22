using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;
using RPG.SheetGenerator.Infrastructure.Context;

namespace RPG.SheetGenerator.Application.Commands.CreateAlignment;

public class CreateUpdateAlignmentCommandHandler : ICommandHandler
{
    private readonly IRepository<Alignment> _repository;

    public CreateUpdateAlignmentCommandHandler(IRepository<Alignment> repository)
    {
        _repository = repository;
    }

    public async Task Insert(ICommand command)
    {
        var model = command as CreateUpdateAlignmentCommand;

        Alignment alignment = new()
        {
            Description = model.Description,
            Name = model.Name
        };

        await _repository.AddAsync(alignment);
    }

    public async Task Update(ICommand command, int id)
    {
        var model = command as CreateUpdateAlignmentCommand;

        Alignment alignment = new()
        {
            Description = model.Description,
            Name = model.Name
        };

        await _repository.UpdateAsync(alignment, id);
    }

    public async Task Delete(int id) => await _repository.DeleteById(id);

    public Task Update(ICommand command, Guid id)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}