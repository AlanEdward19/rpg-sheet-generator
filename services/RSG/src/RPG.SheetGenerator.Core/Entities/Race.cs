namespace RPG.SheetGenerator.Core.Entities;

public class Race
{
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual IEnumerable<Language>? RaceLanguages { get; set; }
}