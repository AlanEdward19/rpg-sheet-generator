using RPG.SheetGenerator.Core.Interfaces;

namespace RPG.SheetGenerator.Application.Commands.CreateUpdateAttribute;

public class CreateUpdateAttributeCommand : ICommand
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Value { get; set; }

    public IEnumerable<Guid>? CharacterIds { get; set; }
}