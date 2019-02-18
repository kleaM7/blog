using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog_Klea.Migrations
{
    public partial class firstm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cats",
                table: "BlogPost",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cats",
                table: "BlogPost");
        }
    }
}
