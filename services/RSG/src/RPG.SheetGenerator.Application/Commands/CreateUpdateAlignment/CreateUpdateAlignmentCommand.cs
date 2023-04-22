using RPG.SheetGenerator.Core.Interfaces;

namespace RPG.SheetGenerator.Application.Commands.CreateAlignment;

public class CreateUpdateAlignmentCommand : ICommand
{
    public string Name { get; set; }
    public string Description { get; set; }
}