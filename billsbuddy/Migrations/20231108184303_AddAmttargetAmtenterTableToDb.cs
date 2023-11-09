using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace billsbuddy.Migrations
{
    /// <inheritdoc />
    public partial class AddAmttargetAmtenterTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Net_salary_Users_Id_user",
                table: "Net_salary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Net_salary",
                table: "Net_salary");

            migrationBuilder.RenameTable(
                name: "Net_salary",
                newName: "Net_Salary");

            migrationBuilder.RenameIndex(
                name: "IX_Net_salary_Id_user",
                table: "Net_Salary",
                newName: "IX_Net_Salary_Id_user");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Net_Salary",
                table: "Net_Salary",
                column: "Id_net_salary");

            migrationBuilder.CreateTable(
                name: "Amount_target",
                columns: table => new
                {
                    Id_amt_target = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    grocery = table.Column<double>(type: "float", nullable: false),
                    emergency_money = table.Column<double>(type: "float", nullable: false),
                    eat_outside = table.Column<double>(type: "float", nullable: false),
                    house = table.Column<double>(type: "float", nullable: false),
                    donation = table.Column<double>(type: "float", nullable: false),
                    petrol = table.Column<double>(type: "float", nullable: false),
                    utility = table.Column<double>(type: "float", nullable: false),
                    car = table.Column<double>(type: "float", nullable: false),
                    saving = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_user = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amount_target", x => x.Id_amt_target);
                    table.ForeignKey(
                        name: "FK_Amount_target_Users_Id_user",
                        column: x => x.Id_user,
                        principalTable: "Users",
                        principalColumn: "Id_user",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Amount_enter",
                columns: table => new
                {
                    Id_amt_enter = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    grocery = table.Column<double>(type: "float", nullable: false),
                    emergency_money = table.Column<double>(type: "float", nullable: false),
                    eat_outside = table.Column<double>(type: "float", nullable: false),
                    house = table.Column<double>(type: "float", nullable: false),
                    donation = table.Column<double>(type: "float", nullable: false),
                    petrol = table.Column<double>(type: "float", nullable: false),
                    utility = table.Column<double>(type: "float", nullable: false),
                    car = table.Column<double>(type: "float", nullable: false),
                    saving = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_amt_target = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amount_enter", x => x.Id_amt_enter);
                    table.ForeignKey(
                        name: "FK_Amount_enter_Amount_target_Id_amt_target",
                        column: x => x.Id_amt_target,
                        principalTable: "Amount_target",
                        principalColumn: "Id_amt_target",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Amount_enter_Id_amt_target",
                table: "Amount_enter",
                column: "Id_amt_target");

            migrationBuilder.CreateIndex(
                name: "IX_Amount_target_Id_user",
                table: "Amount_target",
                column: "Id_user");

            migrationBuilder.AddForeignKey(
                name: "FK_Net_Salary_Users_Id_user",
                table: "Net_Salary",
                column: "Id_user",
                principalTable: "Users",
                principalColumn: "Id_user",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Net_Salary_Users_Id_user",
                table: "Net_Salary");

            migrationBuilder.DropTable(
                name: "Amount_enter");

            migrationBuilder.DropTable(
                name: "Amount_target");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Net_Salary",
                table: "Net_Salary");

            migrationBuilder.RenameTable(
                name: "Net_Salary",
                newName: "Net_salary");

            migrationBuilder.RenameIndex(
                name: "IX_Net_Salary_Id_user",
                table: "Net_salary",
                newName: "IX_Net_salary_Id_user");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Net_salary",
                table: "Net_salary",
                column: "Id_net_salary");

            migrationBuilder.AddForeignKey(
                name: "FK_Net_salary_Users_Id_user",
                table: "Net_salary",
                column: "Id_user",
                principalTable: "Users",
                principalColumn: "Id_user",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
