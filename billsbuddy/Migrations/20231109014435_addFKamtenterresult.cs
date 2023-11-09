using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace billsbuddy.Migrations
{
    /// <inheritdoc />
    public partial class addFKamtenterresult : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amount_enter_Amount_target_Id_amt_target",
                table: "Amount_enter");

            migrationBuilder.DropForeignKey(
                name: "FK_AmountResults_Amount_target_Id_amt_target",
                table: "AmountResults");

            migrationBuilder.RenameColumn(
                name: "Id_amt_target",
                table: "AmountResults",
                newName: "Id_user");

            migrationBuilder.RenameIndex(
                name: "IX_AmountResults_Id_amt_target",
                table: "AmountResults",
                newName: "IX_AmountResults_Id_user");

            migrationBuilder.RenameColumn(
                name: "Id_amt_target",
                table: "Amount_enter",
                newName: "Id_user");

            migrationBuilder.RenameIndex(
                name: "IX_Amount_enter_Id_amt_target",
                table: "Amount_enter",
                newName: "IX_Amount_enter_Id_user");

            migrationBuilder.AddForeignKey(
                name: "FK_Amount_enter_Users_Id_user",
                table: "Amount_enter",
                column: "Id_user",
                principalTable: "Users",
                principalColumn: "Id_user",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AmountResults_Users_Id_user",
                table: "AmountResults",
                column: "Id_user",
                principalTable: "Users",
                principalColumn: "Id_user",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amount_enter_Users_Id_user",
                table: "Amount_enter");

            migrationBuilder.DropForeignKey(
                name: "FK_AmountResults_Users_Id_user",
                table: "AmountResults");

            migrationBuilder.RenameColumn(
                name: "Id_user",
                table: "AmountResults",
                newName: "Id_amt_target");

            migrationBuilder.RenameIndex(
                name: "IX_AmountResults_Id_user",
                table: "AmountResults",
                newName: "IX_AmountResults_Id_amt_target");

            migrationBuilder.RenameColumn(
                name: "Id_user",
                table: "Amount_enter",
                newName: "Id_amt_target");

            migrationBuilder.RenameIndex(
                name: "IX_Amount_enter_Id_user",
                table: "Amount_enter",
                newName: "IX_Amount_enter_Id_amt_target");

            migrationBuilder.AddForeignKey(
                name: "FK_Amount_enter_Amount_target_Id_amt_target",
                table: "Amount_enter",
                column: "Id_amt_target",
                principalTable: "Amount_target",
                principalColumn: "Id_amt_target",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AmountResults_Amount_target_Id_amt_target",
                table: "AmountResults",
                column: "Id_amt_target",
                principalTable: "Amount_target",
                principalColumn: "Id_amt_target",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
