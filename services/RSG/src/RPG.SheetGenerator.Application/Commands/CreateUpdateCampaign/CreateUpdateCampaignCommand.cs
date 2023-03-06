namespace RPG.SheetGenerator.Application.Commands.CreateUpdateCampaign;

public class CreateUpdateCampaignCommand
{
    public Guid GamemasterId { get; set; }
    public string CampaignName { get; set; }
    public string Description { get; set; }

    public IEnumerable<Guid>? CharactersId { get; set; }
}