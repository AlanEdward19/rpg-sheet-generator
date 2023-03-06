namespace RPG.SheetGenerator.Application.Commands.CreateUpdateBackground;

public class CreateUpdateBackgroundCommand
{
    public string Name { get; set; }
    public string Description { get; set; }
    public IEnumerable<int>? BackgroundLanguages { get; set; }
    public IEnumerable<int>? BackgroundItems { get; set; }
}