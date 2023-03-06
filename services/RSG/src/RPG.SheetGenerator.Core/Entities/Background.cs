namespace RPG.SheetGenerator.Core.Entities;

public class Background
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public virtual IEnumerable<Language>? BackgroundLanguages { get; set; }
    public virtual IEnumerable<Item>? BackgroundItems { get; set; }
}