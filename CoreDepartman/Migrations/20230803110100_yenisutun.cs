using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreDepartman.Migrations
{
    public partial class yenisutun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Detay",
                table: "departmanlars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Detay",
                table: "departmanlars");
        }
    }
}
