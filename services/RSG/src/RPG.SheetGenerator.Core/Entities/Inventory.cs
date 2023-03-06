using System.ComponentModel.DataAnnotations.Schema;

namespace RPG.SheetGenerator.Core.Entities;

public class Inventory
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Guid CharacterId { get; set; }

    public virtual IEnumerable<Item> Items { get; set; }

    [ForeignKey(nameof(CharacterId))]
    public virtual Character Character { get; set; }
}