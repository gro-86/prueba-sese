using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BreakingLeague.Migrations
{
    /// <inheritdoc />
    public partial class Migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crews_Tournaments_Tournament_Id",
                table: "Crews");

            migrationBuilder.DropForeignKey(
                name: "FK_Judges_Tournaments_Tournament_Id",
                table: "Judges");

            migrationBuilder.DropForeignKey(
                name: "FK_Signed_Bboys_Crews_Crew_Id",
                table: "Signed_Bboys");

            migrationBuilder.DropForeignKey(
                name: "FK_Signed_Bboys_Tournaments_Tournament_Id",
                table: "Signed_Bboys");

            migrationBuilder.AddForeignKey(
                name: "FK_Crews_Tournaments_Tournament_Id",
                table: "Crews",
                column: "Tournament_Id",
                principalTable: "Tournaments",
                principalColumn: "Tournament_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Judges_Tournaments_Tournament_Id",
                table: "Judges",
                column: "Tournament_Id",
                principalTable: "Tournaments",
                principalColumn: "Tournament_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Signed_Bboys_Crews_Crew_Id",
                table: "Signed_Bboys",
                column: "Crew_Id",
                principalTable: "Crews",
                principalColumn: "Crew_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Signed_Bboys_Tournaments_Tournament_Id",
                table: "Signed_Bboys",
                column: "Tournament_Id",
                principalTable: "Tournaments",
                principalColumn: "Tournament_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crews_Tournaments_Tournament_Id",
                table: "Crews");

            migrationBuilder.DropForeignKey(
                name: "FK_Judges_Tournaments_Tournament_Id",
                table: "Judges");

            migrationBuilder.DropForeignKey(
                name: "FK_Signed_Bboys_Crews_Crew_Id",
                table: "Signed_Bboys");

            migrationBuilder.DropForeignKey(
                name: "FK_Signed_Bboys_Tournaments_Tournament_Id",
                table: "Signed_Bboys");

            migrationBuilder.AddForeignKey(
                name: "FK_Crews_Tournaments_Tournament_Id",
                table: "Crews",
                column: "Tournament_Id",
                principalTable: "Tournaments",
                principalColumn: "Tournament_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Judges_Tournaments_Tournament_Id",
                table: "Judges",
                column: "Tournament_Id",
                principalTable: "Tournaments",
                principalColumn: "Tournament_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Signed_Bboys_Crews_Crew_Id",
                table: "Signed_Bboys",
                column: "Crew_Id",
                principalTable: "Crews",
                principalColumn: "Crew_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Signed_Bboys_Tournaments_Tournament_Id",
                table: "Signed_Bboys",
                column: "Tournament_Id",
                principalTable: "Tournaments",
                principalColumn: "Tournament_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
