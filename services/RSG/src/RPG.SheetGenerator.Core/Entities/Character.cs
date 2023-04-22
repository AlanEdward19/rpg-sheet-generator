using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RPG.SheetGenerator.Core.Entities;

[Table("Character")]
public class Character
    {
        [Key]
        [Column("CharacterId")]
        public Guid Id { get; set; }
        public Guid PlayerId { get; set; }
        public int RaceId { get; set; }
        public Guid? CampaignId { get; set; }
        public int BackgroundId { get; set; }
        public int AlignmentId { get; set; }
        public int InventoryId { get; set; }

        [Column("CharacterName")]
        public string NickName { get; set; }
        public int Age { get; set; }
        public int Level { get; set; }
        public int ExperiencePoints { get; set; }
        public int Speed { get; set; }
        public int ArmorClass { get; set; }
        public int HitPoints { get; set; }
        public string PersonalityTraits { get; set; }
        public string Ideals { get; set; }
        public string Bonds { get; set; }
        public string Flaws { get; set; }

        [ForeignKey(nameof(PlayerId))]
        public virtual Player Player { get; set; }

        [ForeignKey(nameof(RaceId))]
        public virtual Race Race { get; set; }

        [ForeignKey(nameof(BackgroundId))]
        public virtual Background Background { get; set; }

        [ForeignKey(nameof(AlignmentId))]
        public virtual Alignment Alignment { get; set; }

        [ForeignKey(nameof(InventoryId))]
        public virtual Inventory Inventory { get; set; }

        [ForeignKey(nameof(CampaignId))]
        public virtual Campaign? Campaign { get; set; }

        public virtual IEnumerable<Language> Languages { get; set; }
        public virtual IEnumerable<Proficiency> Proficiencies { get; set; }
        public virtual IEnumerable<Attribute> Attributes { get; set; }
        public virtual IEnumerable<Class> Classes { get; set; }

        public void NewCharacter()
        {
            Attributes = AddBaseAttributes();
            Inventory = CreateInventory(this);
            Languages = AddBaseLanguages(this);
            Proficiencies = AddProficiencies(this);

            HitPoints = Classes.First().LifeAmount + GetModifier(Attributes.ElementAt(2).Value);
            Level = 1;
            ExperiencePoints = 0;
            Speed = Race.Speed;

        }

        public void AddExp(int amount) // pensar em logica melhor
        {
            ExperiencePoints += amount;

            if(ExperiencePoints >= 355000 && Level == 19)
                LevelUp();
        }

        public void LevelUp()
        {
            Level += 1;
            HitPoints = CalculateHitPoints(HitPoints);
        }
        public int CalculateHitPoints(int amount) => amount += new Random().Next(1, Classes.First().LifeAmount);

        public List<Language> AddBaseLanguages(Character character)
        {
            var backgroundLanguages = character.Background.BackgroundLanguages.ToList();
            var raceLanguages = character.Race.RaceLanguages.ToList();

            List<Language> languages = new();

            foreach (var language in backgroundLanguages)
                languages.Add(language);

            foreach (var language in raceLanguages)
                languages.Add(language);

            return languages;
        }

        public Inventory CreateInventory(Character character)
        {
            var backgroundItems = Background.BackgroundItems.ToList();

            Inventory inventory = new()
            {
                Characters = new List<Character>()
                {
                    character
                }
            };

            Inventory.Name = $"{NickName}'s Inventory";

            foreach (var item in backgroundItems)
            {
                Inventory.AddItem(item);
            }

            return Inventory;
        }

        public List<Attribute> AddBaseAttributes()
        {
            List<Attribute> attributes = new()
            {
                new()
                {
                    Name = "Strength",
                    Description = "Measuring physical power",
                    Value = 10
                },
                new()
                {
                    Name = "Dexterity",
                    Description = "Measuring agility",
                    Value = 10
                },
                new()
                {
                    Name = "Constitution",
                    Description = "Measuring endurance",
                    Value = 10
                },
                new()
                {
                    Name = "Intelligence",
                    Description = "Measuring reasoning and memory",
                    Value = 10
                },
                new()
                {
                    Name = "Wisdom",
                    Description = "Measuring Perception and Insight",
                    Value = 10
                },
                new()
                {
                    Name = "Charisma",
                    Description = "Measuring force of Personality",
                    Value = 10
                }
            };

            attributes = Race.AddRaceBonus(attributes);

            return attributes;
        }

        public List<Proficiency> AddProficiencies(Character character)
        {
            List<Proficiency> proficiencies = new();

            proficiencies.AddRange(character.Background.Proficiencies);

            return proficiencies;
        }

        public int GetModifier(int value) => (value - 10) / 2;
}