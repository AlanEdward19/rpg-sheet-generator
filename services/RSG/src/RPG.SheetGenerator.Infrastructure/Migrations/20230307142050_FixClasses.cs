using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPG.SheetGenerator.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attributes_Character_CharacterId",
                table: "Attributes");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Character_CharacterId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Inventories_InventoryId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Proficiencies_Character_CharacterId",
                table: "Proficiencies");

            migrationBuilder.DropIndex(
                name: "IX_Proficiencies_CharacterId",
                table: "Proficiencies");

            migrationBuilder.DropIndex(
                name: "IX_Items_InventoryId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Classes_CharacterId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Attributes_CharacterId",
                table: "Attributes");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "Proficiencies");

            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "Attributes");

            migrationBuilder.CreateTable(
                name: "AttributeCharacter",
                columns: table => new
                {
                    AttributesId = table.Column<int>(type: "int", nullable: false),
                    CharactersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeCharacter", x => new { x.AttributesId, x.CharactersId });
                    table.ForeignKey(
                        name: "FK_AttributeCharacter_Attributes_AttributesId",
                        column: x => x.AttributesId,
                        principalTable: "Attributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttributeCharacter_Character_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Character",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterClass",
                columns: table => new
                {
                    CharactersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterClass", x => new { x.CharactersId, x.ClassesId });
                    table.ForeignKey(
                        name: "FK_CharacterClass_Character_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Character",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterClass_Classes_ClassesId",
                        column: x => x.ClassesId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterProficiency",
                columns: table => new
                {
                    CharactersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProficienciesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterProficiency", x => new { x.CharactersId, x.ProficienciesId });
                    table.ForeignKey(
                        name: "FK_CharacterProficiency_Character_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Character",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterProficiency_Proficiencies_ProficienciesId",
                        column: x => x.ProficienciesId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InventoryItem",
                columns: table => new
                {
                    InventoriesId = table.Column<int>(type: "int", nullable: false),
                    ItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryItem", x => new { x.InventoriesId, x.ItemsId });
                    table.ForeignKey(
                        name: "FK_InventoryItem_Inventories_InventoriesId",
                        column: x => x.InventoriesId,
                        principalTable: "Inventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InventoryItem_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttributeCharacter_CharactersId",
                table: "AttributeCharacter",
                column: "CharactersId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterClass_ClassesId",
                table: "CharacterClass",
                column: "ClassesId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterProficiency_ProficienciesId",
                table: "CharacterProficiency",
                column: "ProficienciesId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryItem_ItemsId",
                table: "InventoryItem",
                column: "ItemsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttributeCharacter");

            migrationBuilder.DropTable(
                name: "CharacterClass");

            migrationBuilder.DropTable(
                name: "CharacterProficiency");

            migrationBuilder.DropTable(
                name: "InventoryItem");

            migrationBuilder.AddColumn<Guid>(
                name: "CharacterId",
                table: "Proficiencies",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InventoryId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CharacterId",
                table: "Classes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CharacterId",
                table: "Attributes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Proficiencies_CharacterId",
                table: "Proficiencies",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_InventoryId",
                table: "Items",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_CharacterId",
                table: "Classes",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Attributes_CharacterId",
                table: "Attributes",
                column: "CharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attributes_Character_CharacterId",
                table: "Attributes",
                column: "CharacterId",
                principalTable: "Character",
                principalColumn: "CharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Character_CharacterId",
                table: "Classes",
                column: "CharacterId",
                principalTable: "Character",
                principalColumn: "CharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Inventories_InventoryId",
                table: "Items",
                column: "InventoryId",
                principalTable: "Inventories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Proficiencies_Character_CharacterId",
                table: "Proficiencies",
                column: "CharacterId",
                principalTable: "Character",
                principalColumn: "CharacterId");
        }
    }
}
