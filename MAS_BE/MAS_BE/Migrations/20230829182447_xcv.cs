using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MAS_BE.Migrations
{
    public partial class xcv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    IdClient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discount = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.IdClient);
                });

            migrationBuilder.CreateTable(
                name: "Ingridients",
                columns: table => new
                {
                    IdIngridient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingridients", x => x.IdIngridient);
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    IdManager = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.IdManager);
                });

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
                name: "Waiters",
                columns: table => new
                {
                    IdWaiter = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Student = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waiters", x => x.IdWaiter);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    IdReport = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Revenue = table.Column<float>(type: "real", nullable: false),
                    OrderQuantity = table.Column<int>(type: "int", nullable: false),
                    IdManger = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.IdReport);
                    table.ForeignKey(
                        name: "FK_Reports_Managers_IdManger",
                        column: x => x.IdManger,
                        principalTable: "Managers",
                        principalColumn: "IdManager",
                        onDelete: ReferentialAction.Restrict);
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
                    IdReceipt = table.Column<int>(type: "int", nullable: true),
                    IdClient = table.Column<int>(type: "int", nullable: true),
                    IdWaiter = table.Column<int>(type: "int", nullable: true),
                    IdManager = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.IdOrder);
                    table.ForeignKey(
                        name: "FK_Orders_Clients_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Clients",
                        principalColumn: "IdClient",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Managers_IdManager",
                        column: x => x.IdManager,
                        principalTable: "Managers",
                        principalColumn: "IdManager",
                        onDelete: ReferentialAction.Restrict);
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
                    table.ForeignKey(
                        name: "FK_Orders_Waiters_IdWaiter",
                        column: x => x.IdWaiter,
                        principalTable: "Waiters",
                        principalColumn: "IdWaiter",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductIngridients",
                columns: table => new
                {
                    IdProductIngridient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdIngridient = table.Column<int>(type: "int", nullable: false),
                    IdProduct = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductIngridients", x => x.IdProductIngridient);
                    table.ForeignKey(
                        name: "FK_ProductIngridients_Ingridients_IdIngridient",
                        column: x => x.IdIngridient,
                        principalTable: "Ingridients",
                        principalColumn: "IdIngridient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductIngridients_Products_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "Products",
                        principalColumn: "IdProduct",
                        onDelete: ReferentialAction.Cascade);
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
                table: "Clients",
                columns: new[] { "IdClient", "Discount", "Email", "FirstName", "LastName", "NIP", "TelNumber" },
                values: new object[] { 1, true, "email@gmail.com", "Gleb", "Ivanov", null, "12312341" });

            migrationBuilder.InsertData(
                table: "Ingridients",
                columns: new[] { "IdIngridient", "Title", "Weight" },
                values: new object[,]
                {
                    { 1, "First Ingridient", 23.5f },
                    { 2, "Second Ingridient", 25.5f },
                    { 3, "Third Ingridient", 21.5f }
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
                table: "Receipts",
                columns: new[] { "IdReceipt", "NIP", "PaymentMethod", "Sum", "createdAt" },
                values: new object[] { 1, null, 0, 30.4f, new DateTime(2023, 8, 29, 20, 24, 47, 572, DateTimeKind.Local).AddTicks(4140) });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "IdReport", "CreateAt", "IdManger", "OrderQuantity", "Revenue" },
                values: new object[] { 1, new DateTime(2023, 8, 29, 20, 24, 47, 566, DateTimeKind.Local).AddTicks(9082), null, 3, 100f });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "IdOrder", "ClosedAt", "CreateAt", "IdClient", "IdManager", "IdOrderType", "IdReceipt", "IdWaiter", "Sum", "TableNumber" },
                values: new object[,]
                {
                    { 2, null, new DateTime(2023, 8, 29, 20, 24, 47, 573, DateTimeKind.Local).AddTicks(1202), 1, null, 1, null, null, 13f, null },
                    { 1, new DateTime(2023, 8, 29, 20, 24, 47, 573, DateTimeKind.Local).AddTicks(387), new DateTime(2023, 8, 29, 20, 24, 47, 573, DateTimeKind.Local).AddTicks(41), 1, null, 1, 1, null, 30.4f, null }
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
                    { 5, null, null, 2, 4 },
                    { 6, null, null, 2, 6 },
                    { 1, null, null, 1, 1 },
                    { 2, null, null, 1, 2 },
                    { 3, null, null, 1, 3 },
                    { 4, null, null, 1, 5 }
                });

            migrationBuilder.InsertData(
                table: "ProductIngridients",
                columns: new[] { "IdProductIngridient", "IdIngridient", "IdProduct" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 3, 1 },
                    { 3, 2, 2 }
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
                name: "IX_Orders_IdClient",
                table: "Orders",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_IdManager",
                table: "Orders",
                column: "IdManager");

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
                name: "IX_Orders_IdWaiter",
                table: "Orders",
                column: "IdWaiter");

            migrationBuilder.CreateIndex(
                name: "IX_ProductIngridients_IdIngridient",
                table: "ProductIngridients",
                column: "IdIngridient");

            migrationBuilder.CreateIndex(
                name: "IX_ProductIngridients_IdProduct",
                table: "ProductIngridients",
                column: "IdProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Products_IdProductCategory",
                table: "Products",
                column: "IdProductCategory");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_IdManger",
                table: "Reports",
                column: "IdManger");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropTable(
                name: "ProductIngridients");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Ingridients");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "OrderTypes");

            migrationBuilder.DropTable(
                name: "Receipts");

            migrationBuilder.DropTable(
                name: "Waiters");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
