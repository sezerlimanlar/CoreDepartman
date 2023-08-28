using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreDepartman.Migrations
{
    public partial class TestEdiyoruz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departID",
                table: "personels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_personels_departID",
                table: "personels",
                column: "departID");

            migrationBuilder.AddForeignKey(
                name: "FK_personels_departmanlars_departID",
                table: "personels",
                column: "departID",
                principalTable: "departmanlars",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personels_departmanlars_departID",
                table: "personels");

            migrationBuilder.DropIndex(
                name: "IX_personels_departID",
                table: "personels");

            migrationBuilder.DropColumn(
                name: "departID",
                table: "personels");
        }
    }
}
