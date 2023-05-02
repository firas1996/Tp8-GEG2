using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryAPI.Migrations
{
    /// <inheritdoc />
    public partial class last : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CoverUrl", "Description", "Rating", "Title" },
                values: new object[,]
                {
                    { 1, "Author 1", "https://www.book1.com", "Discription 1", 3.3999999999999999, "Book 1" },
                    { 2, "Author 2", "https://www.book2.com", "Discription 2", 3.3999999999999999, "Book 2" },
                    { 3, "Author 3", "https://www.book3.com", "Discription 3", 3.3999999999999999, "Book 3" },
                    { 4, "Author 4", "https://www.book4.com", "Discription 4", 3.3999999999999999, "Book 4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
