using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MAS_BE.Migrations
{
    public partial class nmnm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderTypes",
                columns: table => new
                {
                    IdOrderType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTypes", x => x.IdOrderType);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    IdProductCategory = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.IdProductCategory);
                });

            migrationBuilder.CreateTable(
                name: "Receipts",
                columns: table => new
                {
                    IdReceipt = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sum = table.Column<float>(type: "real", nullable: false),
                    NIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipts", x => x.IdReceipt);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    IdProduct = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    IdProductCategory = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.IdProduct);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_IdProductCategory",
                        column: x => x.IdProductCategory,
                        principalTable: "ProductCategories",
                        principalColumn: "IdProductCategory",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    IdOrder = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sum = table.Column<float>(type: "real", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClosedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdOrderType = table.Column<int>(type: "int", nullable: false),
                    TableNumber = table.Column<int>(type: "int", nullable: true),
                    IdReceipt = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.IdOrder);
                    table.ForeignKey(
                        name: "FK_Orders_OrderTypes_IdOrderType",
                        column: x => x.IdOrderType,
                        principalTable: "OrderTypes",
                        principalColumn: "IdOrderType",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Receipts_IdReceipt",
                        column: x => x.IdReceipt,
                        principalTable: "Receipts",
                        principalColumn: "IdReceipt",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    IdOrderProduct = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProduct = table.Column<int>(type: "int", nullable: false),
                    IdOrder = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => x.IdOrderProduct);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Orders_IdOrder",
                        column: x => x.IdOrder,
                        principalTable: "Orders",
                        principalColumn: "IdOrder",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Products_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "Products",
                        principalColumn: "IdProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "OrderTypes",
                columns: new[] { "IdOrderType", "Title" },
                values: new object[,]
                {
                    { 1, "Take away" },
                    { 2, "For here" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "IdProductCategory", "Title" },
                values: new object[,]
                {
                    { 1, "Food" },
                    { 2, "Drink" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "IdOrder", "ClosedAt", "CreateAt", "IdOrderType", "IdReceipt", "Sum", "TableNumber" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 7, 25, 0, 52, 25, 441, DateTimeKind.Local).AddTicks(9943), 1, null, 30.4f, null },
                    { 2, null, new DateTime(2023, 7, 25, 0, 52, 25, 444, DateTimeKind.Local).AddTicks(499), 1, null, 13f, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "IdProduct", "IdProductCategory", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, 3.7f, "Pizza" },
                    { 2, 1, 11f, "Burger" },
                    { 3, 1, 9.5f, "Sushi" },
                    { 4, 2, 4.8f, "Cosmopolitan" },
                    { 5, 2, 6.2f, "Old Fashion" },
                    { 6, 2, 8.2f, "Pornstar Martini" }
                });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "IdOrderProduct", "CreateAt", "Description", "IdOrder", "IdProduct" },
                values: new object[,]
                {
                    { 1, null, null, 1, 1 },
                    { 2, null, null, 1, 2 },
                    { 3, null, null, 1, 3 },
                    { 5, null, null, 2, 4 },
                    { 4, null, null, 1, 5 },
                    { 6, null, null, 2, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_IdOrder",
                table: "OrderProducts",
                column: "IdOrder");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_IdProduct",
                table: "OrderProducts",
                column: "IdProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_IdOrderType",
                table: "Orders",
                column: "IdOrderType");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_IdReceipt",
                table: "Orders",
                column: "IdReceipt",
                unique: true,
                filter: "[IdReceipt] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_IdProductCategory",
                table: "Products",
                column: "IdProductCategory");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "OrderTypes");

            migrationBuilder.DropTable(
                name: "Receipts");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
