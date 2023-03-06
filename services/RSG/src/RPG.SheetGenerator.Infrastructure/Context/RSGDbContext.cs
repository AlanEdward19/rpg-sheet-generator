using Microsoft.EntityFrameworkCore;
using RPG.SheetGenerator.Core.Entities;
using Attribute = RPG.SheetGenerator.Core.Entities.Attribute;

namespace RPG.SheetGenerator.Infrastructure.Context;

public class RSGDbContext : DbContext
{
    public RSGDbContext(DbContextOptions<RSGDbContext> options) : base(options)
    {
    }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Player>()
    //        .HasMany<Character>()
    //        .
    //}

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