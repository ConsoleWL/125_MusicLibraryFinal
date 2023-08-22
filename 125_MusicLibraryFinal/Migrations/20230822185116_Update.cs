using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _125_MusicLibraryFinal.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PlaylistId", "ReleaseDate" },
                values: new object[] { 2, new DateTime(2023, 8, 22, 14, 51, 16, 83, DateTimeKind.Local).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PlaylistId", "ReleaseDate" },
                values: new object[] { 2, new DateTime(2023, 8, 22, 14, 51, 16, 83, DateTimeKind.Local).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PlaylistId", "ReleaseDate" },
                values: new object[] { 1, new DateTime(2023, 8, 22, 14, 51, 16, 83, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PlaylistId", "ReleaseDate" },
                values: new object[] { 1, new DateTime(2023, 8, 22, 14, 51, 16, 83, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PlaylistId", "ReleaseDate" },
                values: new object[] { 3, new DateTime(2023, 8, 22, 14, 51, 16, 83, DateTimeKind.Local).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PlaylistId", "ReleaseDate" },
                values: new object[] { 3, new DateTime(2023, 8, 22, 14, 51, 16, 83, DateTimeKind.Local).AddTicks(4994) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PlaylistId", "ReleaseDate" },
                values: new object[] { null, new DateTime(2023, 8, 21, 21, 29, 35, 693, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PlaylistId", "ReleaseDate" },
                values: new object[] { null, new DateTime(2023, 8, 21, 21, 29, 35, 693, DateTimeKind.Local).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PlaylistId", "ReleaseDate" },
                values: new object[] { null, new DateTime(2023, 8, 21, 21, 29, 35, 693, DateTimeKind.Local).AddTicks(5991) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PlaylistId", "ReleaseDate" },
                values: new object[] { null, new DateTime(2023, 8, 21, 21, 29, 35, 693, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PlaylistId", "ReleaseDate" },
                values: new object[] { null, new DateTime(2023, 8, 21, 21, 29, 35, 693, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PlaylistId", "ReleaseDate" },
                values: new object[] { null, new DateTime(2023, 8, 21, 21, 29, 35, 693, DateTimeKind.Local).AddTicks(5997) });
        }
    }
}
