using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MAS_BE.Migrations
{
    public partial class FINISH : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "IdManager",
                keyValue: 1,
                column: "DateOfBirthday",
                value: new DateTime(2023, 8, 29, 20, 39, 12, 220, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "IdOrder",
                keyValue: 1,
                columns: new[] { "ClosedAt", "CreateAt" },
                values: new object[] { new DateTime(2023, 8, 29, 20, 39, 12, 222, DateTimeKind.Local).AddTicks(5365), new DateTime(2023, 8, 29, 20, 39, 12, 222, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "IdOrder",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 8, 29, 20, 39, 12, 222, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "Receipts",
                keyColumn: "IdReceipt",
                keyValue: 1,
                column: "createdAt",
                value: new DateTime(2023, 8, 29, 20, 39, 12, 221, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "IdReport",
                keyValue: 1,
                columns: new[] { "CreateAt", "IdManger" },
                values: new object[] { new DateTime(2023, 8, 29, 20, 39, 12, 221, DateTimeKind.Local).AddTicks(1114), 1 });

            migrationBuilder.InsertData(
                table: "Waiters",
                columns: new[] { "IdWaiter", "Adress", "Code", "DateOfBirthday", "Email", "FirstName", "LastName", "Student", "TelNumber" },
                values: new object[] { 1, "Adress", null, new DateTime(2023, 8, 29, 20, 39, 12, 217, DateTimeKind.Local).AddTicks(8820), "email@gmail.com", "Gleb", "Ivanov", true, "14312412" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Waiters",
                keyColumn: "IdWaiter",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "IdManager",
                keyValue: 1,
                column: "DateOfBirthday",
                value: new DateTime(2023, 8, 29, 20, 33, 47, 669, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "IdOrder",
                keyValue: 1,
                columns: new[] { "ClosedAt", "CreateAt" },
                values: new object[] { new DateTime(2023, 8, 29, 20, 33, 47, 674, DateTimeKind.Local).AddTicks(3319), new DateTime(2023, 8, 29, 20, 33, 47, 674, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "IdOrder",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 8, 29, 20, 33, 47, 674, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "Receipts",
                keyColumn: "IdReceipt",
                keyValue: 1,
                column: "createdAt",
                value: new DateTime(2023, 8, 29, 20, 33, 47, 673, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "IdReport",
                keyValue: 1,
                columns: new[] { "CreateAt", "IdManger" },
                values: new object[] { new DateTime(2023, 8, 29, 20, 33, 47, 672, DateTimeKind.Local).AddTicks(9052), null });
        }
    }
}
