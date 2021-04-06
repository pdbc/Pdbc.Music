﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pdbc.Music.Data;

namespace Pdbc.Music.Data.Migrations
{
    [DbContext(typeof(MusicDbContext))]
    [Migration("20210405125126_v2-cascade-action-song-file-information")]
    partial class v2cascadeactionsongfileinformation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArtistSong", b =>
                {
                    b.Property<long>("ArtistsId")
                        .HasColumnType("bigint");

                    b.Property<long>("SongsId")
                        .HasColumnType("bigint");

                    b.HasKey("ArtistsId", "SongsId");

                    b.HasIndex("SongsId");

                    b.ToTable("ArtistSong");
                });

            modelBuilder.Entity("GenreSong", b =>
                {
                    b.Property<long>("GenresId")
                        .HasColumnType("bigint");

                    b.Property<long>("SongsId")
                        .HasColumnType("bigint");

                    b.HasKey("GenresId", "SongsId");

                    b.HasIndex("SongsId");

                    b.ToTable("GenreSong");
                });

            modelBuilder.Entity("Pdbc.Music.Domain.Model.Album", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTimeOffset>("ModifiedOn")
                        .IsConcurrencyToken()
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("Pdbc.Music.Domain.Model.Artist", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTimeOffset>("ModifiedOn")
                        .IsConcurrencyToken()
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("Pdbc.Music.Domain.Model.FileInformation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CurrentFullPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Directory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Extension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Filename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTimeOffset>("ModifiedOn")
                        .IsConcurrencyToken()
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("FileInformations");
                });

            modelBuilder.Entity("Pdbc.Music.Domain.Model.Genre", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTimeOffset>("ModifiedOn")
                        .IsConcurrencyToken()
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Pdbc.Music.Domain.Model.Playlist", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTimeOffset>("ModifiedOn")
                        .IsConcurrencyToken()
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("Pdbc.Music.Domain.Model.Song", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("AlbumId")
                        .HasColumnType("bigint");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<long?>("FileInformationId")
                        .HasColumnType("bigint");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTimeOffset>("ModifiedOn")
                        .IsConcurrencyToken()
                        .HasColumnType("datetimeoffset");

                    b.Property<long?>("PlaylistId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.HasIndex("FileInformationId");

                    b.HasIndex("PlaylistId");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("ArtistSong", b =>
                {
                    b.HasOne("Pdbc.Music.Domain.Model.Artist", null)
                        .WithMany()
                        .HasForeignKey("ArtistsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pdbc.Music.Domain.Model.Song", null)
                        .WithMany()
                        .HasForeignKey("SongsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GenreSong", b =>
                {
                    b.HasOne("Pdbc.Music.Domain.Model.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pdbc.Music.Domain.Model.Song", null)
                        .WithMany()
                        .HasForeignKey("SongsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pdbc.Music.Domain.Model.Song", b =>
                {
                    b.HasOne("Pdbc.Music.Domain.Model.Album", null)
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId");

                    b.HasOne("Pdbc.Music.Domain.Model.FileInformation", "FileInformation")
                        .WithMany()
                        .HasForeignKey("FileInformationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pdbc.Music.Domain.Model.Playlist", null)
                        .WithMany("Songs")
                        .HasForeignKey("PlaylistId");

                    b.Navigation("FileInformation");
                });

            modelBuilder.Entity("Pdbc.Music.Domain.Model.Album", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("Pdbc.Music.Domain.Model.Playlist", b =>
                {
                    b.Navigation("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}