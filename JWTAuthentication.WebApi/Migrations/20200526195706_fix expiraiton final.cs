using Microsoft.EntityFrameworkCore.Migrations;

namespace JWTAuthentication.WebApi.Migrations
{
    public partial class fixexpiraitonfinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReplacedByToken",
                table: "RefreshToken");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReplacedByToken",
                table: "RefreshToken",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
