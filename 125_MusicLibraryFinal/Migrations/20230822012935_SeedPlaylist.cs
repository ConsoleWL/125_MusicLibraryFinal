using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _125_MusicLibraryFinal.Migrations
{
    /// <inheritdoc />
    public partial class SeedPlaylist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Playlists",
                columns: new[] { "PlaylistId", "Name" },
                values: new object[,]
                {
                    { 1, "Rok" },
                    { 2, "Pop" },
                    { 3, "Rap" }
                });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 21, 21, 29, 35, 693, DateTimeKind.Local).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 21, 21, 29, 35, 693, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 21, 21, 29, 35, 693, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 21, 21, 29, 35, 693, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 21, 21, 29, 35, 693, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 21, 21, 29, 35, 693, DateTimeKind.Local).AddTicks(5997));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 21, 21, 26, 9, 901, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 21, 21, 26, 9, 901, DateTimeKind.Local).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 21, 21, 26, 9, 901, DateTimeKind.Local).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 21, 21, 26, 9, 901, DateTimeKind.Local).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 21, 21, 26, 9, 901, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 21, 21, 26, 9, 901, DateTimeKind.Local).AddTicks(3007));
        }
    }
}
