using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FM.WebSite.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fault_Fridge_FridgesFridgeId",
                table: "Fault");

            migrationBuilder.DropIndex(
                name: "IX_Fault_FridgesFridgeId",
                table: "Fault");

            migrationBuilder.DropColumn(
                name: "FridgesFridgeId",
                table: "Fault");

            migrationBuilder.AddColumn<int>(
                name: "FridgeId",
                table: "Fault",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Fault",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Fault_FridgeId",
                table: "Fault",
                column: "FridgeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fault_Fridge_FridgeId",
                table: "Fault",
                column: "FridgeId",
                principalTable: "Fridge",
                principalColumn: "FridgeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fault_Fridge_FridgeId",
                table: "Fault");

            migrationBuilder.DropIndex(
                name: "IX_Fault_FridgeId",
                table: "Fault");

            migrationBuilder.DropColumn(
                name: "FridgeId",
                table: "Fault");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Fault");

            migrationBuilder.AddColumn<int>(
                name: "FridgesFridgeId",
                table: "Fault",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fault_FridgesFridgeId",
                table: "Fault",
                column: "FridgesFridgeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fault_Fridge_FridgesFridgeId",
                table: "Fault",
                column: "FridgesFridgeId",
                principalTable: "Fridge",
                principalColumn: "FridgeId");
        }
    }
}
