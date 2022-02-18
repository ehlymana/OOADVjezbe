using Microsoft.EntityFrameworkCore.Migrations;

namespace PrvaASPNETAplikacija.Migrations
{
    public partial class MigracijaSlika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Slika",
                table: "Student",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slika",
                table: "Student");
        }
    }
}
