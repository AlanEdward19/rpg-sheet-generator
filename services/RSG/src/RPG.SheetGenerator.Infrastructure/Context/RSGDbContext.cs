using Microsoft.EntityFrameworkCore;
using RPG.SheetGenerator.Core.Entities;
using Attribute = RPG.SheetGenerator.Core.Entities.Attribute;

namespace RPG.SheetGenerator.Infrastructure.Context;

public class RSGDbContext : DbContext
{
    public RSGDbContext(DbContextOptions<RSGDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Alignment>().HasData(new List<Alignment>()
        {
            new()
            {
                Name = "Lawful good",
                Description =
                    "A lawful good character is a protector. The iconic example of lawful good is a paladin, a holy knight who protects the weak and destroys evil.",
                Id = 1
            },
            new()
            {
                Name = "Neutral good",
                Description = "A neutral good character believes in altruism over all else.",
                Id = 2
            },
            new()
            {
                Name = "Chaotic good",
                Description =
                    "A Chaotic Good character believes in freedom as the highest virtue. The iconic example of chaotic good is Robin Hood, who rebels against authority as a way to protect the poor from poverty and suffering.",
                Id = 3
            },
            new()
            {
                Name = "Lawful neutral",
                Description =
                    "A lawful neutral character obeys principle as the highest virtue. For example, a judge who treats all fairly and equally would be considered lawful neutral.",
                Id = 4
            },
            new()
            {
                Name = "True neutral",
                Description =
                    "A true neutral character is neutral on both axes, and cares not for any stance of alignment. This often describes someone who cares only for their own personal needs, neither inclined to hurt or harm others, nor to obey or rebel.",
                Id = 5
            },
            new()
            {
                Name = "Chaotic neutral",
                Description =
                    "A chaotic neutral character follows their heart, but without the willingness to self-sacrifice as a chaotic good character might. A great many adventurers are chaotic neutral, doing what they wish and rejecting all forms of authority. Some chaotic neutral characters follow a deliberate philosophy of destroying the old to make way for the new.",
                Id = 6
            },
            new()
            {
                Name = "Lawful evil",
                Description =
                    "A lawful evil character is a tyrant. They have no moral qualms about punishing individuals for the greater goal of furthering society. A lawful evil villain is often easy to deal with, as they can often be trusted to keep their word.",
                Id = 7
            },
            new()
            {
                Name = "Neutral evil",
                Description =
                    "A neutral evil character is selfish, and has no problem harming others to get what they want - if they can get away with it.",
                Id = 8
            },
            new()
            {
                Name = "Chaotic evil",
                Description =
                    "A chaotic evil character is malevolent. A villain bent on revenge might be of this alignment. Where the most powerful lawful evil villains might aim to conquer the world, this might be preferable to their chaotic evil counterparts, who would destroy it.",
                Id = 9
            },
            new()
            {
                Name = "Unaligned",
                Description =
                    "Creature without the ability to make rational moral choices may be considered to have no alignment at all. In Dungeons & Dragons 5th edition, creatures such as animals fall into this category and are considered unaligned.",
                Id = 10
            },
        });
        
    }

    public DbSet<Alignment> Alignments { get; set; }
    public DbSet<Attribute> Attributes { get; set; }
    public DbSet<Background> Backgrounds { get; set; }
    public DbSet<Campaign> Campaigns { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<Class> Classes { get; set; }
    public DbSet<Inventory> Inventories { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<ItemType> ItemTypes { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<Proficiency> Proficiencies { get; set; }
    public DbSet<Race> Races { get; set; }

}