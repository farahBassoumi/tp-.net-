using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tp.Migrations
{
    public partial class genresName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genre_Name",
                table: "movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre_Name",
                table: "movies");
        }
    }
}
