using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RSFRecomendations.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProgrammingLanguagePurpose",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProgrammingLanguageId = table.Column<Guid>(type: "uuid", nullable: false),
                    FormId = table.Column<Guid>(type: "uuid", nullable: false),
                    SelectedPurpose = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammingLanguagePurpose", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgrammingLanguages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<byte[]>(type: "bytea", nullable: true),
                    DifficultyLanguage = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammingLanguages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Login = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<byte[]>(type: "bytea", nullable: false),
                    Salt = table.Column<byte[]>(type: "bytea", nullable: false),
                    Image = table.Column<byte[]>(type: "bytea", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgrammingLanguageModelProgrammingLanguagePurposeModel",
                columns: table => new
                {
                    ProgrammingLanguagesId = table.Column<Guid>(type: "uuid", nullable: false),
                    PurposesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammingLanguageModelProgrammingLanguagePurposeModel", x => new { x.ProgrammingLanguagesId, x.PurposesId });
                    table.ForeignKey(
                        name: "FK_ProgrammingLanguageModelProgrammingLanguagePurposeModel_Pro~",
                        column: x => x.ProgrammingLanguagesId,
                        principalTable: "ProgrammingLanguages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgrammingLanguageModelProgrammingLanguagePurposeModel_Pr~1",
                        column: x => x.PurposesId,
                        principalTable: "ProgrammingLanguagePurpose",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PurposeId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProgrammingSkillUser = table.Column<int>(type: "integer", nullable: true),
                    TimeEducationInWeek = table.Column<int>(type: "integer", nullable: true),
                    Priority = table.Column<int>(type: "integer", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormModels_ProgrammingLanguagePurpose_PurposeId",
                        column: x => x.PurposeId,
                        principalTable: "ProgrammingLanguagePurpose",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormModels_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProgrammingLanguages",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProgrammingLanguageId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProgrammingLanguages", x => new { x.UserId, x.ProgrammingLanguageId });
                    table.ForeignKey(
                        name: "FK_UserProgrammingLanguages_ProgrammingLanguages_ProgrammingLa~",
                        column: x => x.ProgrammingLanguageId,
                        principalTable: "ProgrammingLanguages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProgrammingLanguages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormModels_PurposeId",
                table: "FormModels",
                column: "PurposeId");

            migrationBuilder.CreateIndex(
                name: "IX_FormModels_UserId",
                table: "FormModels",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProgrammingLanguageModelProgrammingLanguagePurposeModel_Pur~",
                table: "ProgrammingLanguageModelProgrammingLanguagePurposeModel",
                column: "PurposesId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProgrammingLanguages_ProgrammingLanguageId",
                table: "UserProgrammingLanguages",
                column: "ProgrammingLanguageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormModels");

            migrationBuilder.DropTable(
                name: "ProgrammingLanguageModelProgrammingLanguagePurposeModel");

            migrationBuilder.DropTable(
                name: "UserProgrammingLanguages");

            migrationBuilder.DropTable(
                name: "ProgrammingLanguagePurpose");

            migrationBuilder.DropTable(
                name: "ProgrammingLanguages");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
