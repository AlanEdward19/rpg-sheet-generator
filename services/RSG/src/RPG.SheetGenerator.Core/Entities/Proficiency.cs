using System.ComponentModel.DataAnnotations.Schema;

namespace RPG.SheetGenerator.Core.Entities;

public class Proficiency
{
    public int Id { get; set; }
    public int AttributeId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    [ForeignKey(nameof(AttributeId))]
    public virtual Attribute Attribute { get; set; }
}