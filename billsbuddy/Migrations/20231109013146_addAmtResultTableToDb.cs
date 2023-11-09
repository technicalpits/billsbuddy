using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace billsbuddy.Migrations
{
    /// <inheritdoc />
    public partial class addAmtResultTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AmountResults",
                columns: table => new
                {
                    Id_amt_result = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_AmountResults", x => x.Id_amt_result);
                    table.ForeignKey(
                        name: "FK_AmountResults_Amount_target_Id_amt_target",
                        column: x => x.Id_amt_target,
                        principalTable: "Amount_target",
                        principalColumn: "Id_amt_target",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AmountResults_Id_amt_target",
                table: "AmountResults",
                column: "Id_amt_target");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmountResults");
        }
    }
}
