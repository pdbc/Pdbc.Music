using Microsoft.EntityFrameworkCore.Migrations;

namespace Pdbc.Music.Data.Migrations
{
    public partial class v3cascadeactionsongfileinformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_FileInformations_FileInformationId",
                schema: "dbo",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Songs_FileInformationId",
                schema: "dbo",
                table: "Songs");

            migrationBuilder.AddColumn<long>(
                name: "SongId",
                schema: "dbo",
                table: "FileInformations",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_FileInformations_SongId",
                schema: "dbo",
                table: "FileInformations",
                column: "SongId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FileInformations_Songs_SongId",
                schema: "dbo",
                table: "FileInformations",
                column: "SongId",
                principalSchema: "dbo",
                principalTable: "Songs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileInformations_Songs_SongId",
                schema: "dbo",
                table: "FileInformations");

            migrationBuilder.DropIndex(
                name: "IX_FileInformations_SongId",
                schema: "dbo",
                table: "FileInformations");

            migrationBuilder.DropColumn(
                name: "SongId",
                schema: "dbo",
                table: "FileInformations");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_FileInformationId",
                schema: "dbo",
                table: "Songs",
                column: "FileInformationId");

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
    }
}
