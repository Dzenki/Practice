using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HSR_CHARACTERS.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharactersPaths",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PathImageIRL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharactersPaths", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CharactersTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeImageIRL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharactersTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CharactersInformations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharacterImageIRL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PathId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CharactersTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CharactersPathId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharactersInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharactersInformations_CharactersPaths_CharactersPathId",
                        column: x => x.CharactersPathId,
                        principalTable: "CharactersPaths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharactersInformations_CharactersTypes_CharactersTypeId",
                        column: x => x.CharactersTypeId,
                        principalTable: "CharactersTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharactersInformations_CharactersPathId",
                table: "CharactersInformations",
                column: "CharactersPathId");

            migrationBuilder.CreateIndex(
                name: "IX_CharactersInformations_CharactersTypeId",
                table: "CharactersInformations",
                column: "CharactersTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharactersInformations");

            migrationBuilder.DropTable(
                name: "CharactersPaths");

            migrationBuilder.DropTable(
                name: "CharactersTypes");
        }
    }
}
