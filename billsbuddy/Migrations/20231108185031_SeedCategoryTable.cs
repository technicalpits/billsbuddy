using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace billsbuddy.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id_user", "Date", "email", "password", "phone" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 9, 15, 30, 45, 0, DateTimeKind.Unspecified), "nuratkz93@gmail.com", "1234", "0133130589" },
                    { 2, new DateTime(2023, 11, 9, 15, 36, 45, 0, DateTimeKind.Unspecified), "toyaleran93@gmail.com", "1234", "01159881106" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id_user",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id_user",
                keyValue: 2);
        }
    }
}
