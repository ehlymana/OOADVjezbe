using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace StudentskaSluzba.Migrations
{
    public partial class PrvaMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Predmet",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ECTS = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Predmet", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Ime = table.Column<string>(type: "varchar(767)", nullable: false),
                    Prezime = table.Column<string>(type: "text", nullable: false),
                    BrojIndeksa = table.Column<int>(type: "int", nullable: false),
                    GodinaStudija = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Ime);
                });

            migrationBuilder.CreateTable(
                name: "UpisNaPredmet",
                columns: table => new
                {
                    BrojProtokola = table.Column<string>(type: "varchar(767)", nullable: false),
                    AkademskaGodina = table.Column<int>(type: "int", nullable: false),
                    DatumUpisa = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpisNaPredmet", x => x.BrojProtokola);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Predmet");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "UpisNaPredmet");
        }
    }
}
