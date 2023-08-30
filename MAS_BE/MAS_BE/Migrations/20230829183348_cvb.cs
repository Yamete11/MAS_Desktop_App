using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MAS_BE.Migrations
{
    public partial class cvb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Managers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Managers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirthday",
                table: "Managers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Managers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Managers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Managers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "SALARY",
                table: "Managers",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<bool>(
                name: "Student",
                table: "Managers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "TelNumber",
                table: "Managers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "IdManager", "Adress", "Code", "DateOfBirthday", "Email", "FirstName", "LastName", "SALARY", "Student", "TelNumber" },
                values: new object[] { 1, "Adress", "123", new DateTime(2023, 8, 29, 20, 33, 47, 669, DateTimeKind.Local).AddTicks(7605), "email@gmail.com", "Gleb", "Ivanov", 12f, true, "14312412" });

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
                column: "CreateAt",
                value: new DateTime(2023, 8, 29, 20, 33, 47, 672, DateTimeKind.Local).AddTicks(9052));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "IdManager",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "DateOfBirthday",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "SALARY",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "Student",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "TelNumber",
                table: "Managers");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "IdOrder",
                keyValue: 1,
                columns: new[] { "ClosedAt", "CreateAt" },
                values: new object[] { new DateTime(2023, 8, 29, 20, 24, 47, 573, DateTimeKind.Local).AddTicks(387), new DateTime(2023, 8, 29, 20, 24, 47, 573, DateTimeKind.Local).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "IdOrder",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 8, 29, 20, 24, 47, 573, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Receipts",
                keyColumn: "IdReceipt",
                keyValue: 1,
                column: "createdAt",
                value: new DateTime(2023, 8, 29, 20, 24, 47, 572, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "IdReport",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 8, 29, 20, 24, 47, 566, DateTimeKind.Local).AddTicks(9082));
        }
    }
}
