using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tp.Migrations
{
    public partial class hb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Membershiptype_membershipTypeIdId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "membershipTypeIdId",
                table: "Customers",
                newName: "MembershipTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_membershipTypeIdId",
                table: "Customers",
                newName: "IX_Customers_MembershipTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Membershiptype_MembershipTypeId",
                table: "Customers",
                column: "MembershipTypeId",
                principalTable: "Membershiptype",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Membershiptype_MembershipTypeId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "MembershipTypeId",
                table: "Customers",
                newName: "membershipTypeIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_MembershipTypeId",
                table: "Customers",
                newName: "IX_Customers_membershipTypeIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Membershiptype_membershipTypeIdId",
                table: "Customers",
                column: "membershipTypeIdId",
                principalTable: "Membershiptype",
                principalColumn: "Id");
        }
    }
}
