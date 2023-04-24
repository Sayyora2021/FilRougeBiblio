using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilRougeBiblio.Infrastructure.Data.Migrations
{
    public partial class FilRougeBiblio_V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MotsClefs_Livres_LivreId",
                table: "MotsClefs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MotsClefs",
                table: "MotsClefs");

            migrationBuilder.RenameTable(
                name: "MotsClefs",
                newName: "MotClefs");

            migrationBuilder.RenameIndex(
                name: "IX_MotsClefs_LivreId",
                table: "MotClefs",
                newName: "IX_MotClefs_LivreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MotClefs",
                table: "MotClefs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MotClefs_Livres_LivreId",
                table: "MotClefs",
                column: "LivreId",
                principalTable: "Livres",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MotClefs_Livres_LivreId",
                table: "MotClefs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MotClefs",
                table: "MotClefs");

            migrationBuilder.RenameTable(
                name: "MotClefs",
                newName: "MotsClefs");

            migrationBuilder.RenameIndex(
                name: "IX_MotClefs_LivreId",
                table: "MotsClefs",
                newName: "IX_MotsClefs_LivreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MotsClefs",
                table: "MotsClefs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MotsClefs_Livres_LivreId",
                table: "MotsClefs",
                column: "LivreId",
                principalTable: "Livres",
                principalColumn: "Id");
        }
    }
}
