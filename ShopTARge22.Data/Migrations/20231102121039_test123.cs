using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopTARge22.Data.Migrations
{
    public partial class test123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KidnergartenName",
                table: "Kindergartens",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KidnergartenName",
                table: "Kindergartens");
        }
    }
}
