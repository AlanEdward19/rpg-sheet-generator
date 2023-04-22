using System.ComponentModel.DataAnnotations;

namespace RPG.SheetGenerator.Core.Entities;

public class Attribute
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Value { get; set; }

    public virtual IEnumerable<Character>? Characters { get; set; }
}