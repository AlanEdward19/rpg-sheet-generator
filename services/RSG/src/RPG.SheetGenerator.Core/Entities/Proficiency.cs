namespace RPG.SheetGenerator.Core.Entities;

public class Proficiency
{
    public Guid Id { get; set; }
    public Guid AttributeId { get; set; }
    public string Name { get; set; }
}