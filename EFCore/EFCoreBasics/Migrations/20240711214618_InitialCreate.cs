using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreBasics.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeDto",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpSalarty = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDto", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "ManagerDto",
                columns: table => new
                {
                    ManagerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpLastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerDto", x => x.ManagerId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeDto");

            migrationBuilder.DropTable(
                name: "ManagerDto");
        }
    }
}
