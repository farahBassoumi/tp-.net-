using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tp.Migrations
{
    public partial class moviddb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Membershiptype_membershipTypeIdId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_movies_genres_Genre_IdId",
                table: "movies");

            migrationBuilder.DropIndex(
                name: "IX_movies_Genre_IdId",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "Genre_IdId",
                table: "movies");

            migrationBuilder.AddColumn<Guid>(
                name: "GenreId",
                table: "movies",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Genre_Id",
                table: "movies",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "membershipTypeIdId",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_movies_GenreId",
                table: "movies",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Membershiptype_membershipTypeIdId",
                table: "Customers",
                column: "membershipTypeIdId",
                principalTable: "Membershiptype",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_movies_genres_GenreId",
                table: "movies",
                column: "GenreId",
                principalTable: "genres",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Membershiptype_membershipTypeIdId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_movies_genres_GenreId",
                table: "movies");

            migrationBuilder.DropIndex(
                name: "IX_movies_GenreId",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "Genre_Id",
                table: "movies");

            migrationBuilder.AddColumn<Guid>(
                name: "Genre_IdId",
                table: "movies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "membershipTypeIdId",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_movies_Genre_IdId",
                table: "movies",
                column: "Genre_IdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Membershiptype_membershipTypeIdId",
                table: "Customers",
                column: "membershipTypeIdId",
                principalTable: "Membershiptype",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_movies_genres_Genre_IdId",
                table: "movies",
                column: "Genre_IdId",
                principalTable: "genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
