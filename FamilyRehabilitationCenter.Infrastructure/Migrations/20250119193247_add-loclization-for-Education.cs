using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyRehabilitationCenter.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addloclizationforEducation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MinistryEducationName",
                table: "MinistryEducations",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "Level",
                table: "MinistryEducationLevels",
                newName: "LevelEn");

            migrationBuilder.AddColumn<string>(
                name: "NameAr",
                table: "MinistryEducations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LevelAr",
                table: "MinistryEducationLevels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameAr",
                table: "MinistryEducations");

            migrationBuilder.DropColumn(
                name: "LevelAr",
                table: "MinistryEducationLevels");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "MinistryEducations",
                newName: "MinistryEducationName");

            migrationBuilder.RenameColumn(
                name: "LevelEn",
                table: "MinistryEducationLevels",
                newName: "Level");
        }
    }
}
