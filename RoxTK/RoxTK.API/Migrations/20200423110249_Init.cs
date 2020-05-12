using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace RoxTK.API.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Timekeeps",
                columns: table => new
                {
                    TimekeepId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoggedIn = table.Column<DateTime>(nullable: true),
                    LoggedOut = table.Column<DateTime>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timekeeps", x => x.TimekeepId);
                    table.ForeignKey(
                        name: "FK_Timekeeps_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "FC" },
                    { 3, "HR" },
                    { 4, "Marketing" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "DepartmentId", "Email", "FirstName", "Gender", "ImagePath", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "magana@servio.ph", "Michael Angelo", 0, "Images/Michael.png", "Agana" },
                    { 2, new DateTime(1997, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "daguil@servio.ph", "Dale", 0, "Images/Dale.png", "Aguil" },
                    { 3, new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "mboliver@servio.ph", "Maynard", 0, "Images/Maynard.png", "Boliver" },
                    { 4, new DateTime(1998, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "cdistajo@servio.ph", "Caye Alexis", 1, "Images/Caye.png", "Distajo" },
                    { 5, new DateTime(1998, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "malcazaren@servio.ph", "Mary Rose", 1, "Images/Rose.png", "Alcazaren" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "DateCreated", "Password", "Username" },
                values: new object[] { 1, new DateTime(2020, 4, 23, 19, 2, 49, 466, DateTimeKind.Local).AddTicks(4918), "Password1", "Admin" });

            migrationBuilder.InsertData(
                table: "Timekeeps",
                columns: new[] { "TimekeepId", "DateCreated", "EmployeeId", "LoggedIn", "LoggedOut" },
                values: new object[] { 1, new DateTime(2020, 4, 23, 19, 2, 49, 467, DateTimeKind.Local).AddTicks(9107), 1, new DateTime(2020, 11, 20, 8, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 20, 16, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Timekeeps_EmployeeId",
                table: "Timekeeps",
                column: "EmployeeId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Timekeeps");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
