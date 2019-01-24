using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LexiconMovies.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Genre", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "Science Fiction", 140m, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AI" },
                    { 2, "Comedy", 120m, new DateTime(2018, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "AI FTW" },
                    { 3, "Drama", 160m, new DateTime(2009, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generations" },
                    { 4, "Splatter", 80m, new DateTime(1989, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Return of the Killer Penguins" },
                    { 5, "Splatter", 60m, new DateTime(1964, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Killer Penguins from Space" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
