using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog_Klea.Migrations
{
    public partial class postfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "BlogPost",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                table: "BlogPost",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
