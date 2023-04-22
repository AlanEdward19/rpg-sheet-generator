using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RPG.SheetGenerator.Core.Entities;

public class Inventory
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual IEnumerable<Item> Items { get; set; }
    public virtual IEnumerable<Character> Characters { get; set; }

    public void AddItem(Item item) => Items.Append(item);
}