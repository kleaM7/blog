using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog_Klea.Migrations
{
    public partial class @checked : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ischecked",
                table: "Categories",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ischecked",
                table: "Categories");
        }
    }
}
