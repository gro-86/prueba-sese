using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BreakingLeague.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crews_Tournaments_Tournament_Id",
                table: "Crews");

            migrationBuilder.DropForeignKey(
                name: "FK_Signed_Bboys_Tournaments_Tournament_Id",
                table: "Signed_Bboys");

            migrationBuilder.DropIndex(
                name: "IX_Crews_Tournament_Id",
                table: "Crews");

            migrationBuilder.AddColumn<int>(
                name: "Tournament_Id1",
                table: "Crews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Crews_Tournament_Id1",
                table: "Crews",
                column: "Tournament_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Crews_Tournaments_Tournament_Id1",
                table: "Crews",
                column: "Tournament_Id1",
                principalTable: "Tournaments",
                principalColumn: "Tournament_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Signed_Bboys_Tournaments_Tournament_Id",
                table: "Signed_Bboys",
                column: "Tournament_Id",
                principalTable: "Tournaments",
                principalColumn: "Tournament_Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crews_Tournaments_Tournament_Id1",
                table: "Crews");

            migrationBuilder.DropForeignKey(
                name: "FK_Signed_Bboys_Tournaments_Tournament_Id",
                table: "Signed_Bboys");

            migrationBuilder.DropIndex(
                name: "IX_Crews_Tournament_Id1",
                table: "Crews");

            migrationBuilder.DropColumn(
                name: "Tournament_Id1",
                table: "Crews");

            migrationBuilder.CreateIndex(
                name: "IX_Crews_Tournament_Id",
                table: "Crews",
                column: "Tournament_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Crews_Tournaments_Tournament_Id",
                table: "Crews",
                column: "Tournament_Id",
                principalTable: "Tournaments",
                principalColumn: "Tournament_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Signed_Bboys_Tournaments_Tournament_Id",
                table: "Signed_Bboys",
                column: "Tournament_Id",
                principalTable: "Tournaments",
                principalColumn: "Tournament_Id");
        }
    }
}
