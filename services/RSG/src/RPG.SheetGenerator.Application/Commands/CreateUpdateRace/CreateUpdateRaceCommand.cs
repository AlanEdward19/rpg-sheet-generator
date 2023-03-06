namespace RPG.SheetGenerator.Application.Commands.CreateUpdateRace;

public class CreateUpdateRaceCommand
{
    public string Name { get; set; }

    public IEnumerable<int>? LanguageId { get; set; }
}