﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RPG.SheetGenerator.Infrastructure.Context;

#nullable disable

namespace RPG.SheetGenerator.Infrastructure.Migrations
{
    [DbContext(typeof(RSGDbContext))]
    [Migration("20230307142050_FixClasses")]
    partial class FixClasses
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AttributeCharacter", b =>
                {
                    b.Property<int>("AttributesId")
                        .HasColumnType("int");

                    b.Property<Guid>("CharactersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AttributesId", "CharactersId");

                    b.HasIndex("CharactersId");

                    b.ToTable("AttributeCharacter");
                });

            modelBuilder.Entity("CharacterClass", b =>
                {
                    b.Property<Guid>("CharactersId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ClassesId")
                        .HasColumnType("int");

                    b.HasKey("CharactersId", "ClassesId");

                    b.HasIndex("ClassesId");

                    b.ToTable("CharacterClass");
                });

            modelBuilder.Entity("CharacterProficiency", b =>
                {
                    b.Property<Guid>("CharactersId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ProficienciesId")
                        .HasColumnType("int");

                    b.HasKey("CharactersId", "ProficienciesId");

                    b.HasIndex("ProficienciesId");

                    b.ToTable("CharacterProficiency");
                });

            modelBuilder.Entity("InventoryItem", b =>
                {
                    b.Property<int>("InventoriesId")
                        .HasColumnType("int");

                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.HasKey("InventoriesId", "ItemsId");

                    b.HasIndex("ItemsId");

                    b.ToTable("InventoryItem");
                });

            modelBuilder.Entity("RPG.SheetGenerator.Core.Entities.Alignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Alignments");
                });

            modelBuilder.Entity("RPG.SheetGenerator.Core.Entities.Attribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Attributes");
                });

            modelBuilder.Entity("RPG.SheetGenerator.Core.Entities.Background", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Backgrounds");
                });

            modelBuilder.Entity("RPG.SheetGenerator.Core.Entities.Campaign", b =>
                {
                    b.Property<Guid>("CampaignId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CampaignName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("GamemasterId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CampaignId");

                    b.HasIndex("GamemasterId");

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("RPG.SheetGenerator.Core.Entities.Character", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CharacterId");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("AlignmentId")
                        .HasColumnType("int");

                    b.Property<int>("ArmorClass")
                        .HasColumnType("int");

                    b.Property<int>("BackgroundId")
                        .HasColumnType("int");

                    b.Property<string>("Bonds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CampaignId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ExperiencePoints")
                        .HasColumnType("int");

                    b.Property<string>("Flaws")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HitPoints")
                        .HasColumnType("int");

                    b.Property<string>("Ideals")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InventoryId")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CharacterName");

                    b.Property<string>("PersonalityTraits")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PlayerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RaceId")
                        .HasColumnType("int");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlignmentId");

                    b.HasIndex("BackgroundId");

                    b.HasIndex("CampaignId");

                    b.HasIndex("InventoryId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("RaceId");

                    b.ToTable("Character");
                });

            modelBuilder.Entity("RPG.SheetGenerator.Core.Entities.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LifeAmount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("RPG.SheetGenerator.Core.Entities.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("RPG.SheetGenerator.Core.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BackgroundId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BackgroundId");

                    b.HasIndex("TypeId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("RPG.SheetGenerator.Core.Entities.ItemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ItemTypes");
                });

            modelBuilder.Entity("RPG.SheetGenerator.Core.Entities.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BackgroundId")
                        .HasColumnType("int");

                    b.Property<Guid?>("CharacterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RaceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BackgroundId");

                    b.HasIndex("CharacterId");

                    b.HasIndex("RaceId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("RPG.SheetGenerator.Core.Entities.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("RPG.SheetGenerator.Core.Entities.Proficiency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AttributeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AttributeId");

                    b.ToTable("Proficiencies");
                });

            modelBuilder.Entity("RPG.SheetGenerator.Core.Entities.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("AttributeCharacter", b =>
                {
                    b.HasOne("RPG.SheetGenerator.Core.Entities.Attribute", null)
                        .WithMany()
                        .HasForeignKey("AttributesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPG.SheetGenerator.Core.Entities.Character", null)
                        .WithMany()
                        .HasForeignKey("CharactersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterClass", b =>
                {
                    b.HasOne("RPG.SheetGenerator.Core.Entities.Character", null)
                        .WithMany()
                        .HasForeignKey("CharactersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPG.SheetGenerator.Core.Entities.Class", null)
                        .WithMany()
                        .HasForeignKey("ClassesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterProficiency", b =>
                {
                    b.HasOne("RPG.SheetGenerator.Core.Entities.Character", null)
                        .WithMany()
                        .HasForeignKey("CharactersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPG.SheetGenerator.Core.Entities.Proficiency", null)
                        .WithMany()
                        .HasForeignKey("ProficienciesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InventoryItem", b =>
                {
                    b.HasOne("RPG.SheetGenerator.Core.Entities.Inventory", null)
                        .WithMany()
                        .HasForeignKey("InventoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPG.SheetGenerator.Core.Entities.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RPG.SheetGenerator.Core.Entities.Campaign", b =>
                {
                    b.HasOne("RPG.SheetGenerator.Core.Entities.Player", "Gamemaster")
                        .WithMany()
                        .HasForeignKey("GamemasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gamemaster");
                });

            modelBuilder.Entity("RPG.SheetGenerator.Core.Entities.Character", b =>
                {
                    b.HasOne("RPG.SheetGenerator.Core.Entities.Alignment", "Alignment")
                        .WithMany()
                        .HasForeignKey("AlignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPG.SheetGenerator.Core.Entities.Background", "Background")
                        .WithMany()
                        .HasForeignKey("BackgroundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPG.SheetGenerator.Core.Entities.Campaign", "Campaign")
                        .WithMany("Characters")
                        .HasForeignKey("CampaignId");

                    b.HasOne("RPG.SheetGenerator.Core.Entities.Inventory", "Inventory")
                        .WithMany("Characters")
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPG.SheetGenerator.Core.Entities.Player", "Player")
                        .WithMany("Characters")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPG.SheetGenerator.Core.Entities.Race", "Race")
                        .WithMany()
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alignment");

                    b.Navigation("Background");

                    b.Navigation("Campaign");

                    b.Navigation("Inventory");

                    b.Navigation("Player");

                    b.Navigation("Race");
                });

            modelBuilder.Entity("RPG.SheetGenerator.Core.Entities.Item", b =>
                {
                    b.HasOne("RPG.SheetGenerator.Core.Entities.Background", null)
                        .WithMany("BackgroundItems")
                        .HasForeignKey("BackgroundId");

                    b.HasOne("RPG.SheetGenerator.Core.Entities.ItemType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("RPG.SheetGenerator.Core.Entities.Language", b =>
                {
                    b.HasOne("RPG.SheetGenerator.Core.Entities.Background", null)
                        .WithMany("BackgroundLanguages")
                        .HasForeignKey("BackgroundId");

                    b.HasOne("RPG.SheetGenerator.Core.Entities.Character", null)
                        .WithMany("Languages")
                        .HasForeignKey("CharacterId");

                    b.HasOne("RPG.SheetGenerator.Core.Entities.Race", "Race")
                        .WithMany("RaceLanguages")
                        .HasForeignKey("RaceId");

                    b.Navigation("Race");
                });

            modelBuilder.Entity("RPG.SheetGenerator.Core.Entities.Proficiency", b =>
                {
                    b.HasOne("RPG.SheetGenerator.Core.Entities.Attribute", "Attribute")
                        .WithMany()
                        .HasForeignKey("AttributeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attribute");
                });

            modelBuilder.Entity("RPG.SheetGenerator.Core.Entities.Background", b =>
                {
                    b.Navigation("BackgroundItems");

                    b.Navigation("BackgroundLanguages");
                });

            modelBuilder.Entity("RPG.SheetGenerator.Core.Entities.Campaign", b =>
                {
                    b.Navigation("Characters");
                });

            modelBuilder.Entity("RPG.SheetGenerator.Core.Entities.Character", b =>
                {
                    b.Navigation("Languages");
                });

            modelBuilder.Entity("RPG.SheetGenerator.Core.Entities.Inventory", b =>
                {
                    b.Navigation("Characters");
                });

            modelBuilder.Entity("RPG.SheetGenerator.Core.Entities.Player", b =>
                {
                    b.Navigation("Characters");
                });

            modelBuilder.Entity("RPG.SheetGenerator.Core.Entities.Race", b =>
                {
                    b.Navigation("RaceLanguages");
                });
#pragma warning restore 612, 618
        }
    }
}