using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SupermarketManagmentSystem_SMS.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[,]
                {
                    { 1, "Fruits" },
                    { 2, "Vegetables" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "FirstName", "LastName", "NationalID", "PasswordHash", "Role" },
                values: new object[,]
                {
                    { 1, "Abdo", "Mustafa", "12345678901234", "admin123", 0 },
                    { 2, "Ahmed", "Ali", "23456789012345", "cashier123", 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Barcode", "CategoryID", "ImagePath", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "", 1, null, "Apple", 1.2m, 0 },
                    { 2, "", 1, null, "Banana", 0.8m, 0 },
                    { 3, "", 2, null, "Carrot", 0.5m, 0 },
                    { 4, "", 2, null, "Broccoli", 1.0m, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_NationalID",
                table: "Users",
                column: "NationalID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_NationalID",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2);
        }
    }
}
