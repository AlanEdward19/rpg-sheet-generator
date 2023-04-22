using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RPG.SheetGenerator.Core.Entities;

public class Proficiency
{
    [Key]
    public int Id { get; set; }
    public int AttributeId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    [ForeignKey(nameof(AttributeId))]
    public virtual Attribute Attribute { get; set; }

    public virtual IEnumerable<Character> Characters { get; set; }
}