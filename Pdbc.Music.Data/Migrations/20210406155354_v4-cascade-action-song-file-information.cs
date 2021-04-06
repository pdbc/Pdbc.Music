using Microsoft.EntityFrameworkCore.Migrations;

namespace Pdbc.Music.Data.Migrations
{
    public partial class v4cascadeactionsongfileinformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FileInformations_SongId",
                schema: "dbo",
                table: "FileInformations");

            migrationBuilder.AlterColumn<long>(
                name: "SongId",
                schema: "dbo",
                table: "FileInformations",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateIndex(
                name: "IX_FileInformations_SongId",
                schema: "dbo",
                table: "FileInformations",
                column: "SongId",
                unique: true,
                filter: "[SongId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FileInformations_SongId",
                schema: "dbo",
                table: "FileInformations");

            migrationBuilder.AlterColumn<long>(
                name: "SongId",
                schema: "dbo",
                table: "FileInformations",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FileInformations_SongId",
                schema: "dbo",
                table: "FileInformations",
                column: "SongId",
                unique: true);
        }
    }
}
