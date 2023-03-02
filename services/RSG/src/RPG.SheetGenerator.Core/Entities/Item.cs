namespace RPG.SheetGenerator.Core.Entities;

public class Item
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int TypeId { get; set; }

    public virtual ItemType Type { get; set; }
}