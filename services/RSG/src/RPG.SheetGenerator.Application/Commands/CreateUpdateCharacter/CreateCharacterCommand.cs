using RPG.SheetGenerator.Core.Entities;

namespace RPG.SheetGenerator.Application.Commands.CreateUpdateCharacter;

public class CreateCharacterCommand
{
    public Guid PlayerId { get; set; }
    public int RaceId { get; set; }
    public Guid? CampaignId { get; set; }
    public int BackgroundId { get; set; }
    public int AlignmentId { get; set; }
    public string NickName { get; set; }
    public int Age { get; set; }
    public int ArmorClass { get; set; }
    public string PersonalityTraits { get; set; }
    public string Ideals { get; set; }
    public string Bonds { get; set; }
    public string Flaws { get; set; }

    public IEnumerable<int>? ItemsId { get; set; }
    public IEnumerable<int>? LanguagesId { get; set; }
    public IEnumerable<int> ProficienciesId { get; set; }
    public int ClassId { get; set; }
}