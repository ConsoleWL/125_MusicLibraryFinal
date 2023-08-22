﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _125_MusicLibraryFinal.Data;

#nullable disable

namespace _125_MusicLibraryFinal.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230822185116_Update")]
    partial class Update
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("_125_MusicLibraryFinal.Models.Playlist", b =>
                {
                    b.Property<int>("PlaylistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PlaylistId");

                    b.ToTable("Playlists");

                    b.HasData(
                        new
                        {
                            PlaylistId = 1,
                            Name = "Rok"
                        },
                        new
                        {
                            PlaylistId = 2,
                            Name = "Pop"
                        },
                        new
                        {
                            PlaylistId = 3,
                            Name = "Rap"
                        });
                });

            modelBuilder.Entity("_125_MusicLibraryFinal.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Album")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Genre")
                        .HasColumnType("longtext");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<int?>("PlaylistId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("PlaylistId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Album = "Feedback",
                            Artist = "Arsm",
                            Genre = "Pop",
                            Likes = 0,
                            PlaylistId = 2,
                            ReleaseDate = new DateTime(2023, 8, 22, 14, 51, 16, 83, DateTimeKind.Local).AddTicks(4935),
                            Title = "Txt"
                        },
                        new
                        {
                            Id = 2,
                            Album = "Todat",
                            Artist = "HasData",
                            Genre = "Pop",
                            Likes = 0,
                            PlaylistId = 2,
                            ReleaseDate = new DateTime(2023, 8, 22, 14, 51, 16, 83, DateTimeKind.Local).AddTicks(4984),
                            Title = "Migrations  "
                        },
                        new
                        {
                            Id = 3,
                            Album = "One ",
                            Artist = "HasData",
                            Genre = "Rock",
                            Likes = 0,
                            PlaylistId = 1,
                            ReleaseDate = new DateTime(2023, 8, 22, 14, 51, 16, 83, DateTimeKind.Local).AddTicks(4987),
                            Title = "Blog"
                        },
                        new
                        {
                            Id = 4,
                            Album = "Custom ",
                            Artist = "See ",
                            Genre = "Rock",
                            Likes = 0,
                            PlaylistId = 1,
                            ReleaseDate = new DateTime(2023, 8, 22, 14, 51, 16, 83, DateTimeKind.Local).AddTicks(4990),
                            Title = "Thus  "
                        },
                        new
                        {
                            Id = 5,
                            Album = "Temporary ",
                            Artist = "See ",
                            Genre = "Rap",
                            Likes = 0,
                            PlaylistId = 3,
                            ReleaseDate = new DateTime(2023, 8, 22, 14, 51, 16, 83, DateTimeKind.Local).AddTicks(4992),
                            Title = "Note"
                        },
                        new
                        {
                            Id = 6,
                            Album = "Therefore ",
                            Artist = "Limitations ",
                            Genre = "Rap",
                            Likes = 0,
                            PlaylistId = 3,
                            ReleaseDate = new DateTime(2023, 8, 22, 14, 51, 16, 83, DateTimeKind.Local).AddTicks(4994),
                            Title = "Additional "
                        });
                });

            modelBuilder.Entity("_125_MusicLibraryFinal.Models.Song", b =>
                {
                    b.HasOne("_125_MusicLibraryFinal.Models.Playlist", "Playlist")
                        .WithMany("Songs")
                        .HasForeignKey("PlaylistId");

                    b.Navigation("Playlist");
                });

            modelBuilder.Entity("_125_MusicLibraryFinal.Models.Playlist", b =>
                {
                    b.Navigation("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}
