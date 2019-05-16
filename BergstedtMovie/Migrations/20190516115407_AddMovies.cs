﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BergstedtMovie.Migrations
{
    public partial class AddMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Genre", "Rating", "ReleaseDate", "Title" },
                values: new object[] { 1, 3, 5f, new DateTime(1997, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Titanic" });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Genre", "Rating", "ReleaseDate", "Title" },
                values: new object[] { 2, 0, 2.3f, new DateTime(2005, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scream" });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Genre", "Rating", "ReleaseDate", "Title" },
                values: new object[] { 3, 0, 4.9f, new DateTime(1979, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shining" });
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
        }
    }
}
