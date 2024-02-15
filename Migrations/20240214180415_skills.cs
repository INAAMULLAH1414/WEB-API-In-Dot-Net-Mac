using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEBAPIInDotNetMac.Migrations
{
    /// <inheritdoc />
    public partial class skills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SkillId",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Damage = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_SkillId",
                table: "Characters",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_SkillId",
                table: "Skills",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Skills_SkillId",
                table: "Characters",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Skills_SkillId",
                table: "Characters");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Characters_SkillId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "SkillId",
                table: "Characters");
        }
    }
}
