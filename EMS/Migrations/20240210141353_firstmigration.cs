using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeptMaster",
                columns: table => new
                {
                    DeptCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeptMaster", x => x.DeptCode);
                });

            migrationBuilder.CreateTable(
                name: "EmpProfile",
                columns: table => new
                {
                    EmpCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeptCode = table.Column<int>(type: "int", nullable: false),
                    DeptMasterDeptCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpProfile", x => x.EmpCode);
                    table.ForeignKey(
                        name: "FK_EmpProfile_DeptMaster_DeptMasterDeptCode",
                        column: x => x.DeptMasterDeptCode,
                        principalTable: "DeptMaster",
                        principalColumn: "DeptCode");
                });

            migrationBuilder.InsertData(
                table: "DeptMaster",
                columns: new[] { "DeptCode", "DeptName" },
                values: new object[,]
                {
                    { 1, "Information Technology" },
                    { 2, "Human Resources" },
                    { 3, "Finance" },
                    { 4, "Marketing" },
                    { 5, "Sales" },
                    { 6, "Customer Support" },
                    { 7, "Research and Development" },
                    { 8, "Supply Chain" },
                    { 9, "Legal" },
                    { 10, "Public Relations" }
                });

            migrationBuilder.InsertData(
                table: "EmpProfile",
                columns: new[] { "EmpCode", "DateOfBirth", "DeptCode", "DeptMasterDeptCode", "Email", "EmpName" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "john.doe@example.com", "John Doe" },
                    { 2, new DateTime(1991, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "jane.smith@example.com", "Jane Smith" },
                    { 3, new DateTime(1992, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "william.johnson@example.com", "William Johnson" },
                    { 4, new DateTime(1993, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "patricia.williams@example.com", "Patricia Williams" },
                    { 5, new DateTime(1994, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, "michael.brown@example.com", "Michael Brown" },
                    { 6, new DateTime(1995, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, null, "linda.davis@example.com", "Linda Davis" },
                    { 7, new DateTime(1996, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, null, "robert.miller@example.com", "Robert Miller" },
                    { 8, new DateTime(1997, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, null, "elizabeth.wilson@example.com", "Elizabeth Wilson" },
                    { 9, new DateTime(1998, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, null, "james.moore@example.com", "James Moore" },
                    { 10, new DateTime(1999, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, null, "barbara.taylor@example.com", "Barbara Taylor" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpProfile_DeptMasterDeptCode",
                table: "EmpProfile",
                column: "DeptMasterDeptCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpProfile");

            migrationBuilder.DropTable(
                name: "DeptMaster");
        }
    }
}
