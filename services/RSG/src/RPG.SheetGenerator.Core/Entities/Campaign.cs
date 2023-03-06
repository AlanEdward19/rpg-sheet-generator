using System.ComponentModel.DataAnnotations.Schema;

namespace RPG.SheetGenerator.Core.Entities;
public class Campaign
{
    public Guid CampaignId { get; set; }
    public Guid GamemasterId { get; set; }
    public string CampaignName { get; set; }
    public string Description { get; set; }

    [ForeignKey(nameof(GamemasterId))]
    public virtual Player Gamemaster { get; set; }

    public virtual IEnumerable<Character>? Characters { get; set; }
}