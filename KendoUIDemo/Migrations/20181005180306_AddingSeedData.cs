using Microsoft.EntityFrameworkCore.Migrations;

namespace KendoUIDemo.Migrations
{
    public partial class AddingSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "NumberOfPages", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Tolstoy", 900, 19.95m, "War and Peace" },
                    { 2, "Stephenson", 550, 9.95m, "Anathem" },
                    { 3, "Faulkner", 325, 5.50m, "As I Lay Dying" },
                    { 4, "Dostoyevsky", 700, 18.99m, "Brother K" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 4);
        }
    }
}
