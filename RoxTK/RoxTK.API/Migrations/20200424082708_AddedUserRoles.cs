using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace RoxTK.API.Migrations
{
    public partial class AddedUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Timekeeps",
                keyColumn: "TimekeepId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 4, 24, 16, 27, 8, 209, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 4, 24, 16, 27, 8, 208, DateTimeKind.Local).AddTicks(3276));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Timekeeps",
                keyColumn: "TimekeepId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 19, 2, 49, 467, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 19, 2, 49, 466, DateTimeKind.Local).AddTicks(4918));
        }
    }
}
