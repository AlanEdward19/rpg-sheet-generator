using System.ComponentModel.DataAnnotations;

namespace RPG.SheetGenerator.Core.Entities;

public class Race
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Speed { get; set; }

    public virtual IEnumerable<Language>? RaceLanguages { get; set; }

    public List<Attribute> AddRaceBonus(List<Attribute> attributes)
    {
        List<Attribute> bonusAttributes = attributes;

        string raceName = Name.ToLower();

        if (raceName.Contains("humano"))
        {
            bonusAttributes[0].Value += 1;
            bonusAttributes[1].Value += 1;
            bonusAttributes[2].Value += 1;
            bonusAttributes[3].Value += 1;
            bonusAttributes[4].Value += 1;
            bonusAttributes[5].Value += 1;
        }
        else if (raceName.Contains("dwarf"))
        {
            bonusAttributes[0].Value += 2;
            bonusAttributes[2].Value += 2;
            bonusAttributes[4].Value += 1;
        }
        else if (raceName.Contains("halfling"))
        {
            bonusAttributes[1].Value += 2;
            bonusAttributes[2].Value += 1;
            bonusAttributes[5].Value += 1;
        }
        else if (raceName.Contains("dragonborn"))
        {
            bonusAttributes[0].Value += 2;
            bonusAttributes[5].Value += 1;
        }
        else if (raceName.Contains("half-orc"))
        {
            bonusAttributes[0].Value += 2;
            bonusAttributes[2].Value += 1;
        }
        else if (raceName.Contains("half-elf"))
        {
            bonusAttributes[5].Value += 2;
        }
        else if (raceName.Contains("elf"))
        {
            bonusAttributes[1].Value += 2;
            bonusAttributes[3].Value += 1;
            bonusAttributes[4].Value += 1;
        }

        return bonusAttributes;
    }
}