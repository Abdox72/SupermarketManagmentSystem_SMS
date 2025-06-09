using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupermarketManagmentSystem_SMS.Migrations
{
    /// <inheritdoc />
    public partial class updateforme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$XJaXQUyQxAOfRtAEcEa6ceT8JOkSddFJGoGSj9RwuLA8yDDm3588S");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$r8CKo/O6euw/dl/38mn6eeyAOfwzKS30qApeQ.Kbb5BwY4XQqn2Dq");
        }
    }
}
