using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BreakingLeague.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crews_Tournaments_Tournament_Id1",
                table: "Crews");

            migrationBuilder.DropColumn(
                name: "Tournament_Id",
                table: "Crews");

            migrationBuilder.RenameColumn(
                name: "Tournament_Id1",
                table: "Crews",
                newName: "TournamentId");

            migrationBuilder.RenameIndex(
                name: "IX_Crews_Tournament_Id1",
                table: "Crews",
                newName: "IX_Crews_TournamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Crews_Tournaments_TournamentId",
                table: "Crews",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Tournament_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crews_Tournaments_TournamentId",
                table: "Crews");

            migrationBuilder.RenameColumn(
                name: "TournamentId",
                table: "Crews",
                newName: "Tournament_Id1");

            migrationBuilder.RenameIndex(
                name: "IX_Crews_TournamentId",
                table: "Crews",
                newName: "IX_Crews_Tournament_Id1");

            migrationBuilder.AddColumn<int>(
                name: "Tournament_Id",
                table: "Crews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Crews_Tournaments_Tournament_Id1",
                table: "Crews",
                column: "Tournament_Id1",
                principalTable: "Tournaments",
                principalColumn: "Tournament_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
