using System.ComponentModel.DataAnnotations;

namespace RPG.SheetGenerator.Core.Entities;

public class Player
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public virtual IEnumerable<Character>? Characters { get; set; }
}