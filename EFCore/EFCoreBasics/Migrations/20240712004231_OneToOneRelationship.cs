using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreBasics.Migrations
{
    /// <inheritdoc />
    public partial class OneToOneRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ManagerDto",
                table: "ManagerDto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeDto",
                table: "EmployeeDto");

            migrationBuilder.RenameTable(
                name: "ManagerDto",
                newName: "Manager");

            migrationBuilder.RenameTable(
                name: "EmployeeDto",
                newName: "Employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manager",
                table: "Manager",
                column: "ManagerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeId");

            migrationBuilder.CreateTable(
                name: "EmployeeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhonNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeDetails_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_EmployeeId",
                table: "EmployeeDetails",
                column: "EmployeeId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Manager",
                table: "Manager");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Manager",
                newName: "ManagerDto");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "EmployeeDto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ManagerDto",
                table: "ManagerDto",
                column: "ManagerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeDto",
                table: "EmployeeDto",
                column: "EmployeeId");
        }
    }
}
