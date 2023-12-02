using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tp.Migrations
{
    public partial class noasba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "asbaa",
                table: "movies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "asbaa",
                table: "movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
