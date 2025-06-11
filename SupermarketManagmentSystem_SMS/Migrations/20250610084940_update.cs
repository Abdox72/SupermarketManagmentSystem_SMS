using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupermarketManagmentSystem_SMS.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$Qfbm.xMkxnC/P5eXUNhNbu8B8xLpMcoCUvPo4lmUL0UPEZbDtEOlK");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$3M0QAhnahTkUAaeSq/mWRuj98W2J4FFIa7FwCvOZwsa3GSYbJGrJK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$EbCNYvmukYSrMAejZN./KOhy.Tl49CNfrzATjKzbRcqkGSKnwM632");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$/6DRtsugMWNHwXzYm9RmUuRBjzB0HIMwBv6Kybw8Rx39Tg.lb9UU.");
        }
    }
}
