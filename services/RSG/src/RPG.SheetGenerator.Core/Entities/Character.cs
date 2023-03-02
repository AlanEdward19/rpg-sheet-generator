using System.ComponentModel.DataAnnotations.Schema;

namespace RPG.SheetGenerator.Core.Entities;
public class Character
    {
        public Guid Id { get; set; }
        public Guid PlayerId { get; set; }
        public int RaceId { get; set; }
        public Guid CampaignId { get; set; }
        public Guid BackgroundId { get; set; }
        public int AlignmentId { get; set; }
        public Guid InventoryId { get; set; }

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

        public virtual IEnumerable<Languages> Languages { get; set; }
        public virtual IEnumerable<Proficiency> Proficiencies { get; set; }
        public virtual IEnumerable<Attributes> Attributes { get; set; }
        public virtual IEnumerable<Classes> Classes { get; set; }
    }