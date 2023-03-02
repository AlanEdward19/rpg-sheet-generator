namespace RPG.SheetGenerator.Core.Entities;

public class Inventory
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Guid CharacterId { get; set; }

    public IEnumerable<Item> Items { get; set; }
}