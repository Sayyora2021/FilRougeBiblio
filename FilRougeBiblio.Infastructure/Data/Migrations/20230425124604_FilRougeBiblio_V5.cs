using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilRougeBiblio.Infrastructure.Data.Migrations
{
    public partial class FilRougeBiblio_V5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Cotisation",
                table: "Lecteurs",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cotisation",
                table: "Lecteurs");
        }
    }
}
