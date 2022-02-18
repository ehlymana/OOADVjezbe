using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrvaASPNETAplikacija.Migrations
{
    public partial class DrugaMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DatumUpisa",
                table: "UpisNaPredmet",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Predmet",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatumUpisa",
                table: "UpisNaPredmet");

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Predmet",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);
        }
    }
}
