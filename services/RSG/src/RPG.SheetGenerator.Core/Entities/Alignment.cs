using System.ComponentModel.DataAnnotations;

namespace RPG.SheetGenerator.Core.Entities;

public class Alignment
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}