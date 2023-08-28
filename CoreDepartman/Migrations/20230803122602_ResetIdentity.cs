using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreDepartman.Migrations
{
    public partial class ResetIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DBCC CHECKIDENT('departmanlars', RESEED, 0)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
