using System.ComponentModel.DataAnnotations;

namespace RPG.SheetGenerator.Core.Entities;

public class Background
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public virtual IEnumerable<Language>? BackgroundLanguages { get; set; }
    public virtual IEnumerable<Item>? BackgroundItems { get; set; }
    public virtual IEnumerable<Proficiency>? Proficiencies { get; set; }
}