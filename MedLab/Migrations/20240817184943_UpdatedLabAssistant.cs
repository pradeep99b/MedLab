using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedLab.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedLabAssistant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "LabAssistant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LabAssistant_UserId",
                table: "LabAssistant",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_LabAssistant_AspNetUsers_UserId",
                table: "LabAssistant",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LabAssistant_AspNetUsers_UserId",
                table: "LabAssistant");

            migrationBuilder.DropIndex(
                name: "IX_LabAssistant_UserId",
                table: "LabAssistant");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "LabAssistant");
        }
    }
}
