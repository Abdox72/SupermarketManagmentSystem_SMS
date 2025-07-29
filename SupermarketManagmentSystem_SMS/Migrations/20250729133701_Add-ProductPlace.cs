using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupermarketManagmentSystem_SMS.Migrations
{
    /// <inheritdoc />
    public partial class AddProductPlace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Place",
                table: "Products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "Place",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "Place",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "Place",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "Place",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "PasswordHash" },
                values: new object[] { "محمد", "أحمد", "$2a$11$vZvzeTmS6wB/nU5dScAvQOsekddeBZQOGTgpg00IF6DxAvqNvMfWe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "PasswordHash" },
                values: new object[] { "سيد", "علي", "$2a$11$EMs/u/CKXhCG/bB3CnRLZeYnxoVVtgZ5CZyhseZinf2m7DhVrQEKG" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Place",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "PasswordHash" },
                values: new object[] { "Abdo", "Mustafa", "$2a$11$Qfbm.xMkxnC/P5eXUNhNbu8B8xLpMcoCUvPo4lmUL0UPEZbDtEOlK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "PasswordHash" },
                values: new object[] { "Ahmed", "Ali", "$2a$11$3M0QAhnahTkUAaeSq/mWRuj98W2J4FFIa7FwCvOZwsa3GSYbJGrJK" });
        }
    }
}
