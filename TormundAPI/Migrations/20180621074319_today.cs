using Microsoft.EntityFrameworkCore.Migrations;

namespace TormundAPI.Migrations
{
    public partial class today : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "User_type",
                table: "Users",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User_type",
                table: "Users");
        }
    }
}
