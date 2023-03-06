namespace RPG.SheetGenerator.Application.Commands.CreateUpdateInventory;

public class CreateUpdateInventoryCommand
{
    public string Name { get; set; }
    public Guid CharacterId { get; set; }
    public virtual IEnumerable<int> ItemsId { get; set; }
}