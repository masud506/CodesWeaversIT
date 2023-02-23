using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodesWeaverNew.Migrations
{
    public partial class Portfolio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Portfolio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkTitle = table.Column<string>(nullable: true),
                    PersonName = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true),
                    willshown = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolio", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Portfolio");
        }
    }
}
