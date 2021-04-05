using Microsoft.EntityFrameworkCore.Migrations;

namespace Pdbc.Music.Data.Migrations
{
    public partial class v2cascadeactionsongfileinformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_FileInformations_FileInformationId",
                schema: "dbo",
                table: "Songs");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_FileInformations_FileInformationId",
                schema: "dbo",
                table: "Songs",
                column: "FileInformationId",
                principalSchema: "dbo",
                principalTable: "FileInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_FileInformations_FileInformationId",
                schema: "dbo",
                table: "Songs");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_FileInformations_FileInformationId",
                schema: "dbo",
                table: "Songs",
                column: "FileInformationId",
                principalSchema: "dbo",
                principalTable: "FileInformations",
                principalColumn: "Id");
        }
    }
}
