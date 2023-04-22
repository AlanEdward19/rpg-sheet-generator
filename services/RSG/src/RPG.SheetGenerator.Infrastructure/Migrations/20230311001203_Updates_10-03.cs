using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RPG.SheetGenerator.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Updates_1003 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Speed",
                table: "Races",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BackgroundId",
                table: "Proficiencies",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Alignments",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "A lawful good character is a protector. The iconic example of lawful good is a paladin, a holy knight who protects the weak and destroys evil.", "Lawful good" },
                    { 2, "A neutral good character believes in altruism over all else.", "Neutral good" },
                    { 3, "A Chaotic Good character believes in freedom as the highest virtue. The iconic example of chaotic good is Robin Hood, who rebels against authority as a way to protect the poor from poverty and suffering.", "Chaotic good" },
                    { 4, "A lawful neutral character obeys principle as the highest virtue. For example, a judge who treats all fairly and equally would be considered lawful neutral.", "Lawful neutral" },
                    { 5, "A true neutral character is neutral on both axes, and cares not for any stance of alignment. This often describes someone who cares only for their own personal needs, neither inclined to hurt or harm others, nor to obey or rebel.", "True neutral" },
                    { 6, "A chaotic neutral character follows their heart, but without the willingness to self-sacrifice as a chaotic good character might. A great many adventurers are chaotic neutral, doing what they wish and rejecting all forms of authority. Some chaotic neutral characters follow a deliberate philosophy of destroying the old to make way for the new.", "Chaotic neutral" },
                    { 7, "A lawful evil character is a tyrant. They have no moral qualms about punishing individuals for the greater goal of furthering society. A lawful evil villain is often easy to deal with, as they can often be trusted to keep their word.", "Lawful evil" },
                    { 8, "A neutral evil character is selfish, and has no problem harming others to get what they want - if they can get away with it.", "Neutral evil" },
                    { 9, "A chaotic evil character is malevolent. A villain bent on revenge might be of this alignment. Where the most powerful lawful evil villains might aim to conquer the world, this might be preferable to their chaotic evil counterparts, who would destroy it.", "Chaotic evil" },
                    { 10, " creature without the ability to make rational moral choices may be considered to have no alignment at all. In Dungeons & Dragons 5th edition, creatures such as animals fall into this category and are considered unaligned.", "Unaligned" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Proficiencies_BackgroundId",
                table: "Proficiencies",
                column: "BackgroundId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proficiencies_Backgrounds_BackgroundId",
                table: "Proficiencies",
                column: "BackgroundId",
                principalTable: "Backgrounds",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proficiencies_Backgrounds_BackgroundId",
                table: "Proficiencies");

            migrationBuilder.DropIndex(
                name: "IX_Proficiencies_BackgroundId",
                table: "Proficiencies");

            migrationBuilder.DeleteData(
                table: "Alignments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Alignments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Alignments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Alignments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Alignments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Alignments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Alignments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Alignments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Alignments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Alignments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Speed",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "BackgroundId",
                table: "Proficiencies");
        }
    }
}
