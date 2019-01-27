using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IndiaInfo.Data.DAL.Migrations
{
    public partial class AddedStatemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Core");

            migrationBuilder.CreateTable(
                name: "State",
                schema: "Core",
                columns: table => new
                {
                    StateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    DivisionType = table.Column<string>(type: "char(1)", maxLength: 1, nullable: false),
                    IsoCode = table.Column<string>(type: "char(5)", maxLength: 5, nullable: false),
                    VehicleCode = table.Column<string>(type: "char(2)", maxLength: 2, nullable: false),
                    StatehoodDate = table.Column<DateTime>(nullable: false),
                    AdminZone = table.Column<string>(type: "char(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.StateId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "State",
                schema: "Core");
        }
    }
}
