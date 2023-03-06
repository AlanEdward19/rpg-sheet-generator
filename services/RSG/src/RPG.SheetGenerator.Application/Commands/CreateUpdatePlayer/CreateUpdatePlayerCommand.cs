namespace RPG.SheetGenerator.Application.Commands.CreateUpdatePlayer;

public class CreateUpdatePlayerCommand
{
    public string Name { get; set; }
    public string Email { get; set; }
    
    public IEnumerable<Guid>? CharactersId { get; set; }
}