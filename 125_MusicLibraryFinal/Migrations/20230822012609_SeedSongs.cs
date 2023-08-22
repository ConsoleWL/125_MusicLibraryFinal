using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _125_MusicLibraryFinal.Migrations
{
    /// <inheritdoc />
    public partial class SeedSongs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Album", "Artist", "Genre", "Likes", "PlaylistId", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "Feedback", "Arsm", "Pop", 0, null, new DateTime(2023, 8, 21, 21, 26, 9, 901, DateTimeKind.Local).AddTicks(2946), "Txt" },
                    { 2, "Todat", "HasData", "Pop", 0, null, new DateTime(2023, 8, 21, 21, 26, 9, 901, DateTimeKind.Local).AddTicks(2999), "Migrations  " },
                    { 3, "One ", "HasData", "Rock", 0, null, new DateTime(2023, 8, 21, 21, 26, 9, 901, DateTimeKind.Local).AddTicks(3001), "Blog" },
                    { 4, "Custom ", "See ", "Rock", 0, null, new DateTime(2023, 8, 21, 21, 26, 9, 901, DateTimeKind.Local).AddTicks(3003), "Thus  " },
                    { 5, "Temporary ", "See ", "Rap", 0, null, new DateTime(2023, 8, 21, 21, 26, 9, 901, DateTimeKind.Local).AddTicks(3005), "Note" },
                    { 6, "Therefore ", "Limitations ", "Rap", 0, null, new DateTime(2023, 8, 21, 21, 26, 9, 901, DateTimeKind.Local).AddTicks(3007), "Additional " }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
