using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BreakingLeague.Migrations
{
    /// <inheritdoc />
    public partial class Migracion1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tournaments",
                columns: table => new
                {
                    Tournament_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tournament_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Championship_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournaments", x => x.Tournament_Id);
                });

            migrationBuilder.CreateTable(
                name: "Crews",
                columns: table => new
                {
                    Crew_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Crew_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tournament_Id = table.Column<int>(type: "int", nullable: false),
                    Foundation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crews", x => x.Crew_Id);
                    table.ForeignKey(
                        name: "FK_Crews_Tournaments_Tournament_Id",
                        column: x => x.Tournament_Id,
                        principalTable: "Tournaments",
                        principalColumn: "Tournament_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Judges",
                columns: table => new
                {
                    Judge_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tournament_Id = table.Column<int>(type: "int", nullable: false),
                    Criteria1 = table.Column<int>(type: "int", nullable: false),
                    Criteria2 = table.Column<int>(type: "int", nullable: false),
                    Person_Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Judges", x => x.Judge_Id);
                    table.ForeignKey(
                        name: "FK_Judges_Tournaments_Tournament_Id",
                        column: x => x.Tournament_Id,
                        principalTable: "Tournaments",
                        principalColumn: "Tournament_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Signed_Bboys",
                columns: table => new
                {
                    Bboy_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Crew_Id = table.Column<int>(type: "int", nullable: false),
                    Skill_Id = table.Column<int>(type: "int", nullable: false),
                    Tournament_Id = table.Column<int>(type: "int", nullable: false),
                    Aka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Style_ = table.Column<int>(type: "int", nullable: false),
                    Injured = table.Column<bool>(type: "bit", nullable: false),
                    Trophies = table.Column<int>(type: "int", nullable: false),
                    Attitude = table.Column<int>(type: "int", nullable: false),
                    Person_Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signed_Bboys", x => x.Bboy_Id);
                    table.ForeignKey(
                        name: "FK_Signed_Bboys_Crews_Crew_Id",
                        column: x => x.Crew_Id,
                        principalTable: "Crews",
                        principalColumn: "Crew_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Signed_Bboys_Tournaments_Tournament_Id",
                        column: x => x.Tournament_Id,
                        principalTable: "Tournaments",
                        principalColumn: "Tournament_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Skill_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bboy_Id = table.Column<int>(type: "int", nullable: false),
                    Power = table.Column<double>(type: "float", nullable: false),
                    Footwork = table.Column<double>(type: "float", nullable: false),
                    Freeze = table.Column<double>(type: "float", nullable: false),
                    Style = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Skill_Id);
                    table.ForeignKey(
                        name: "FK_Skills_Signed_Bboys_Bboy_Id",
                        column: x => x.Bboy_Id,
                        principalTable: "Signed_Bboys",
                        principalColumn: "Bboy_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Crews_Tournament_Id",
                table: "Crews",
                column: "Tournament_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Judges_Tournament_Id",
                table: "Judges",
                column: "Tournament_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Signed_Bboys_Crew_Id",
                table: "Signed_Bboys",
                column: "Crew_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Signed_Bboys_Tournament_Id",
                table: "Signed_Bboys",
                column: "Tournament_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_Bboy_Id",
                table: "Skills",
                column: "Bboy_Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Judges");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Signed_Bboys");

            migrationBuilder.DropTable(
                name: "Crews");

            migrationBuilder.DropTable(
                name: "Tournaments");
        }
    }
}
