using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodesWeaverNew.Migrations
{
    public partial class about1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image2",
                table: "About",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image3",
                table: "About",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MissionDescription",
                table: "About",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VissionDescription",
                table: "About",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image2",
                table: "About");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "About");

            migrationBuilder.DropColumn(
                name: "MissionDescription",
                table: "About");

            migrationBuilder.DropColumn(
                name: "VissionDescription",
                table: "About");
        }
    }
}
