using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pdbc.Music.Data.Migrations
{
    public partial class InitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Albums",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ModifiedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Artists",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ModifiedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FileInformations",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentFullPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Filename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Directory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ModifiedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileInformations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ModifiedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Playlists",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ModifiedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: " Songs",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    AlbumId = table.Column<long>(type: "bigint", nullable: true),
                    FileInformationId = table.Column<long>(type: "bigint", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ModifiedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ Songs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ Songs_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalSchema: "dbo",
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ Songs_FileInformations_FileInformationId",
                        column: x => x.FileInformationId,
                        principalSchema: "dbo",
                        principalTable: "FileInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArtistSong",
                schema: "dbo",
                columns: table => new
                {
                    ArtistsId = table.Column<long>(type: "bigint", nullable: false),
                    SongsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistSong", x => new { x.ArtistsId, x.SongsId });
                    table.ForeignKey(
                        name: "FK_ArtistSong_ Songs_SongsId",
                        column: x => x.SongsId,
                        principalSchema: "dbo",
                        principalTable: " Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistSong_Artists_ArtistsId",
                        column: x => x.ArtistsId,
                        principalSchema: "dbo",
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenreSong",
                schema: "dbo",
                columns: table => new
                {
                    GenresId = table.Column<long>(type: "bigint", nullable: false),
                    SongsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreSong", x => new { x.GenresId, x.SongsId });
                    table.ForeignKey(
                        name: "FK_GenreSong_ Songs_SongsId",
                        column: x => x.SongsId,
                        principalSchema: "dbo",
                        principalTable: " Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreSong_Genres_GenresId",
                        column: x => x.GenresId,
                        principalSchema: "dbo",
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlaylistSong",
                schema: "dbo",
                columns: table => new
                {
                    PlaylistsId = table.Column<long>(type: "bigint", nullable: false),
                    SongsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistSong", x => new { x.PlaylistsId, x.SongsId });
                    table.ForeignKey(
                        name: "FK_PlaylistSong_ Songs_SongsId",
                        column: x => x.SongsId,
                        principalSchema: "dbo",
                        principalTable: " Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaylistSong_Playlists_PlaylistsId",
                        column: x => x.PlaylistsId,
                        principalSchema: "dbo",
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ Songs_AlbumId",
                schema: "dbo",
                table: " Songs",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_ Songs_FileInformationId",
                schema: "dbo",
                table: " Songs",
                column: "FileInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_Name",
                schema: "dbo",
                table: "Albums",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Artists_Name",
                schema: "dbo",
                table: "Artists",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ArtistSong_SongsId",
                schema: "dbo",
                table: "ArtistSong",
                column: "SongsId");

            migrationBuilder.CreateIndex(
                name: "IX_Genres_Name",
                schema: "dbo",
                table: "Genres",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GenreSong_SongsId",
                schema: "dbo",
                table: "GenreSong",
                column: "SongsId");

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_Name",
                schema: "dbo",
                table: "Playlists",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistSong_SongsId",
                schema: "dbo",
                table: "PlaylistSong",
                column: "SongsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistSong",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "GenreSong",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PlaylistSong",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Artists",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Genres",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: " Songs",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Playlists",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Albums",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "FileInformations",
                schema: "dbo");
        }
    }
}
