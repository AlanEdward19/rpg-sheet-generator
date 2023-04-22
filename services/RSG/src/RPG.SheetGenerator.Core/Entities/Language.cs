using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RPG.SheetGenerator.Core.Entities;

public class Language
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int? RaceId { get; set; }
    public int? BackgroundId { get; set; }

    [ForeignKey(nameof(RaceId))]
    public virtual Race? Race { get; set; }

    [ForeignKey(nameof(BackgroundId))]
    public virtual Background? Background { get; set; }
}