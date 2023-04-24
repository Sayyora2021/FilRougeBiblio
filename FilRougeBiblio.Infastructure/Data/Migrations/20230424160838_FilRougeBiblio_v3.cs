using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilRougeBiblio.Infrastructure.Data.Migrations
{
    public partial class FilRougeBiblio_v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auteurs_Livres_LivreId",
                table: "Auteurs");

            migrationBuilder.DropForeignKey(
                name: "FK_MotClefs_Livres_LivreId",
                table: "MotClefs");

            migrationBuilder.DropForeignKey(
                name: "FK_Themes_Livres_LivreId",
                table: "Themes");

            migrationBuilder.DropIndex(
                name: "IX_Themes_LivreId",
                table: "Themes");

            migrationBuilder.DropIndex(
                name: "IX_MotClefs_LivreId",
                table: "MotClefs");

            migrationBuilder.DropIndex(
                name: "IX_Auteurs_LivreId",
                table: "Auteurs");

            migrationBuilder.DropColumn(
                name: "LivreId",
                table: "Themes");

            migrationBuilder.DropColumn(
                name: "LivreId",
                table: "MotClefs");

            migrationBuilder.DropColumn(
                name: "LivreId",
                table: "Auteurs");

            migrationBuilder.CreateTable(
                name: "AuteurLivre",
                columns: table => new
                {
                    AuteursId = table.Column<int>(type: "int", nullable: false),
                    LivresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuteurLivre", x => new { x.AuteursId, x.LivresId });
                    table.ForeignKey(
                        name: "FK_AuteurLivre_Auteurs_AuteursId",
                        column: x => x.AuteursId,
                        principalTable: "Auteurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuteurLivre_Livres_LivresId",
                        column: x => x.LivresId,
                        principalTable: "Livres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LivreMotClef",
                columns: table => new
                {
                    LivresId = table.Column<int>(type: "int", nullable: false),
                    TagsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivreMotClef", x => new { x.LivresId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_LivreMotClef_Livres_LivresId",
                        column: x => x.LivresId,
                        principalTable: "Livres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LivreMotClef_MotClefs_TagsId",
                        column: x => x.TagsId,
                        principalTable: "MotClefs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LivreTheme",
                columns: table => new
                {
                    LivresId = table.Column<int>(type: "int", nullable: false),
                    ThemesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivreTheme", x => new { x.LivresId, x.ThemesId });
                    table.ForeignKey(
                        name: "FK_LivreTheme_Livres_LivresId",
                        column: x => x.LivresId,
                        principalTable: "Livres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LivreTheme_Themes_ThemesId",
                        column: x => x.ThemesId,
                        principalTable: "Themes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuteurLivre_LivresId",
                table: "AuteurLivre",
                column: "LivresId");

            migrationBuilder.CreateIndex(
                name: "IX_LivreMotClef_TagsId",
                table: "LivreMotClef",
                column: "TagsId");

            migrationBuilder.CreateIndex(
                name: "IX_LivreTheme_ThemesId",
                table: "LivreTheme",
                column: "ThemesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuteurLivre");

            migrationBuilder.DropTable(
                name: "LivreMotClef");

            migrationBuilder.DropTable(
                name: "LivreTheme");

            migrationBuilder.AddColumn<int>(
                name: "LivreId",
                table: "Themes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LivreId",
                table: "MotClefs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LivreId",
                table: "Auteurs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Themes_LivreId",
                table: "Themes",
                column: "LivreId");

            migrationBuilder.CreateIndex(
                name: "IX_MotClefs_LivreId",
                table: "MotClefs",
                column: "LivreId");

            migrationBuilder.CreateIndex(
                name: "IX_Auteurs_LivreId",
                table: "Auteurs",
                column: "LivreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Auteurs_Livres_LivreId",
                table: "Auteurs",
                column: "LivreId",
                principalTable: "Livres",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MotClefs_Livres_LivreId",
                table: "MotClefs",
                column: "LivreId",
                principalTable: "Livres",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Themes_Livres_LivreId",
                table: "Themes",
                column: "LivreId",
                principalTable: "Livres",
                principalColumn: "Id");
        }
    }
}
