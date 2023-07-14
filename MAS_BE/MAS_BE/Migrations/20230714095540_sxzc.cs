﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MAS_BE.Migrations
{
    public partial class sxzc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "IdOrder",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 7, 14, 11, 55, 39, 939, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "IdOrder",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 7, 14, 11, 55, 39, 941, DateTimeKind.Local).AddTicks(4055));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "IdOrder",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 7, 12, 13, 53, 11, 359, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "IdOrder",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 7, 12, 13, 53, 11, 361, DateTimeKind.Local).AddTicks(5689));
        }
    }
}