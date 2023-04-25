using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilRougeBiblio.Infrastructure.Data.Migrations
{
    public partial class FilRougeBiblio_v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateRetourReel",
                table: "Emprunts",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateRetourReel",
                table: "Emprunts");
        }
    }
}
