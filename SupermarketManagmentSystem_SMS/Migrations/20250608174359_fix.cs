using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupermarketManagmentSystem_SMS.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Sales",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$mzkifGiBKkPnpdd7QRBQO.540v8YIsPx9pis68lEtRlYQBEGhMy2K");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$m5XZWRMSdDo5WMlYPCS8ceKbP604LPPY7NiaEnAqREodeR9BNWOK6");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Sales");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$xHrrYHvQPOWRXFWdVZCRX.njeMAEYV3nAIAy2x/yz/lx2kguJM/1m");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$g4oJgXyQ3lVC.UEqEjyi/O0aDee9QqmZvitt5acyDheYA1RkpHAJO");
        }
    }
}
