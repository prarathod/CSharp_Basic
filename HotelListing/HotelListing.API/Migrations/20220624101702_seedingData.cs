using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.API.Migrations
{
    public partial class seedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "SortName" },
                values: new object[] { 1, "India", "IN" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "SortName" },
                values: new object[] { 2, "BanglaDesh", "BD" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "SortName" },
                values: new object[] { 3, "Pakistan", "PK" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CountryId", "Name", "Ratings" },
                values: new object[,]
                {
                    { 1, "XYZ post amravati", 1, "RamLal Hotel", 4.5 },
                    { 2, "ABC post amravati", 2, "Sham Lal Hotel", 5.0 },
                    { 3, "farshi stop post amravati", 3, "Soromani Hotel", 5.0 },
                    { 4, "XYZ post amravati", 1, "Sita Hotel", 4.5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
