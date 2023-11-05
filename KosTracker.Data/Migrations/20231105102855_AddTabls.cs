using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KosTracker.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTabls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kosten",
                columns: table => new
                {
                    Kategorie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ausgabe = table.Column<float>(type: "real", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "kostenSoll",
                columns: table => new
                {
                    Miete = table.Column<float>(type: "real", nullable: false),
                    Nebenkosten = table.Column<float>(type: "real", nullable: false),
                    Lebensmittel = table.Column<float>(type: "real", nullable: false),
                    Gesundheit = table.Column<float>(type: "real", nullable: false),
                    Versicherung = table.Column<float>(type: "real", nullable: false),
                    Transport = table.Column<float>(type: "real", nullable: false),
                    Bekleidung = table.Column<float>(type: "real", nullable: false),
                    Unterhaltung = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kosten");

            migrationBuilder.DropTable(
                name: "kostenSoll");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
