using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.NET6.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2646d0fa-3eee-435d-8cf9-e8594a244562", "e65a2616-f8c9-4d28-8376-f41926bcc77b", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b48f7aae-05fa-48f0-8e60-7fab09f3587a", "a553db68-8e82-4b85-a9fc-2f1ed3f35eec", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2646d0fa-3eee-435d-8cf9-e8594a244562");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b48f7aae-05fa-48f0-8e60-7fab09f3587a");
        }
    }
}
