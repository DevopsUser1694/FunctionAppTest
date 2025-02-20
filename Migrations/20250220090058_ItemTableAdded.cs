using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FunctionAppTest.Migrations
{
    /// <inheritdoc />
    public partial class ItemTableAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Count", "ItemName", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, "Item_P1_I1", 1 },
                    { 2, 2, "Item_P1_I2", 1 },
                    { 3, 3, "Item_P1_I3", 1 },
                    { 4, 1, "Item_P2_I1", 2 },
                    { 5, 2, "Item_P2_I2", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 2, 20, 14, 30, 58, 570, DateTimeKind.Local).AddTicks(1784), new DateTime(2025, 2, 20, 14, 30, 58, 570, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 2, 20, 14, 30, 58, 570, DateTimeKind.Local).AddTicks(1836), new DateTime(2025, 2, 20, 14, 30, 58, 570, DateTimeKind.Local).AddTicks(1836) });

            migrationBuilder.CreateIndex(
                name: "IX_Items_ProductId",
                table: "Items",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 2, 20, 14, 27, 58, 491, DateTimeKind.Local).AddTicks(8587), new DateTime(2025, 2, 20, 14, 27, 58, 491, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 2, 20, 14, 27, 58, 491, DateTimeKind.Local).AddTicks(8673), new DateTime(2025, 2, 20, 14, 27, 58, 491, DateTimeKind.Local).AddTicks(8674) });
        }
    }
}
