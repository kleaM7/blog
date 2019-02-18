using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog_Klea.Migrations
{
    public partial class fixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_BlogPost_BlogPostID",
                table: "Comment");

            migrationBuilder.RenameColumn(
                name: "BlogPostID",
                table: "Comment",
                newName: "BlogPostId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_BlogPostID",
                table: "Comment",
                newName: "IX_Comment_BlogPostId");

            migrationBuilder.AlterColumn<int>(
                name: "BlogPostId",
                table: "Comment",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnerID",
                table: "Comment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_BlogPost_BlogPostId",
                table: "Comment",
                column: "BlogPostId",
                principalTable: "BlogPost",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_BlogPost_BlogPostId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Comment");

            migrationBuilder.RenameColumn(
                name: "BlogPostId",
                table: "Comment",
                newName: "BlogPostID");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_BlogPostId",
                table: "Comment",
                newName: "IX_Comment_BlogPostID");

            migrationBuilder.AlterColumn<int>(
                name: "BlogPostID",
                table: "Comment",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_BlogPost_BlogPostID",
                table: "Comment",
                column: "BlogPostID",
                principalTable: "BlogPost",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
