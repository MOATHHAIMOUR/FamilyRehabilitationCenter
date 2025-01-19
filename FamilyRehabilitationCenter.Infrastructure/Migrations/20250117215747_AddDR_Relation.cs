using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyRehabilitationCenter.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDR_Relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RegionId",
                table: "Districts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Districts_RegionId",
                table: "Districts",
                column: "RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Regions_RegionId",
                table: "Districts",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "RegionId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Regions_RegionId",
                table: "Districts");

            migrationBuilder.DropIndex(
                name: "IX_Districts_RegionId",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "RegionId",
                table: "Districts");
        }
    }
}
