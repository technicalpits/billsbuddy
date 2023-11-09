using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace billsbuddy.Migrations
{
    /// <inheritdoc />
    public partial class AddNetsalaryAmttargetAmtenterTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Net_salary",
                columns: table => new
                {
                    Id_net_salary = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    amount = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_user = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Net_salary", x => x.Id_net_salary);
                    table.ForeignKey(
                        name: "FK_Net_salary_Users_Id_user",
                        column: x => x.Id_user,
                        principalTable: "Users",
                        principalColumn: "Id_user",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Net_salary_Id_user",
                table: "Net_salary",
                column: "Id_user");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Net_salary");
        }
    }
}
