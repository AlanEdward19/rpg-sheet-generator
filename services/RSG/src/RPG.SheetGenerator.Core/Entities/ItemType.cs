using System.ComponentModel.DataAnnotations;

namespace RPG.SheetGenerator.Core.Entities;

public class ItemType
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}