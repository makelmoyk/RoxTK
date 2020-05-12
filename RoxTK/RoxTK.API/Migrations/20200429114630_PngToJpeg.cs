using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace RoxTK.API.Migrations
{
    public partial class PngToJpeg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "ImagePath",
                value: "Images/Dale.jpeg");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "ImagePath",
                value: "Images/Maynard.jpeg");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "ImagePath",
                value: "Images/Caye.jpeg");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "ImagePath",
                value: "Images/Rose.jpeg");

            migrationBuilder.UpdateData(
                table: "Timekeeps",
                keyColumn: "TimekeepId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 4, 29, 19, 46, 29, 276, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateCreated", "Role" },
                values: new object[] { new DateTime(2020, 4, 29, 19, 46, 29, 273, DateTimeKind.Local).AddTicks(7993), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "ImagePath",
                value: "Images/Dale.png");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "ImagePath",
                value: "Images/Maynard.png");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "ImagePath",
                value: "Images/Caye.png");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "ImagePath",
                value: "Images/Rose.png");

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
                columns: new[] { "DateCreated", "Role" },
                values: new object[] { new DateTime(2020, 4, 24, 16, 27, 8, 208, DateTimeKind.Local).AddTicks(3276), 0 });
        }
    }
}
