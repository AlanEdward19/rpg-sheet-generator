using System.ComponentModel.DataAnnotations.Schema;

namespace RPG.SheetGenerator.Core.Entities;

public class Language
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? RaceId { get; set; }

    [ForeignKey(nameof(RaceId))]
    public virtual Race? Race { get; set; }
}