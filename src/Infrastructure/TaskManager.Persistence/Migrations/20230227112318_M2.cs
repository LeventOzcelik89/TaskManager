using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskManager.Persistence.Migrations
{
    public partial class M2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UT_City",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: true),
                    PlateNumber = table.Column<string>(type: "varchar(2)", nullable: true),
                    PhoneCode = table.Column<string>(type: "varchar(10)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UT_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UT_Country",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code2 = table.Column<string>(type: "varchar(2)", nullable: true),
                    Code3 = table.Column<string>(type: "varchar(3)", nullable: true),
                    Name = table.Column<string>(type: "varchar(100)", nullable: true),
                    PhoneCode = table.Column<string>(type: "varchar(10)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UT_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UT_Town",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: true),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UT_Town", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UT_Town_UT_City_CityId",
                        column: x => x.CityId,
                        principalTable: "UT_City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SH_User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(100)", nullable: true),
                    LastName = table.Column<string>(type: "varchar(100)", nullable: true),
                    Email = table.Column<string>(type: "varchar(250)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CellPhone = table.Column<string>(type: "varchar(10)", nullable: true),
                    IdentityNumber = table.Column<string>(type: "varchar(11)", nullable: true),
                    Password = table.Column<string>(type: "varchar(250)", nullable: true),
                    TownId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SH_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SH_User_UT_City_CityId",
                        column: x => x.CityId,
                        principalTable: "UT_City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SH_User_UT_Town_TownId",
                        column: x => x.TownId,
                        principalTable: "UT_Town",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SH_User_CityId",
                table: "SH_User",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_SH_User_TownId",
                table: "SH_User",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_UT_Town_CityId",
                table: "UT_Town",
                column: "CityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SH_User");

            migrationBuilder.DropTable(
                name: "UT_Country");

            migrationBuilder.DropTable(
                name: "UT_Town");

            migrationBuilder.DropTable(
                name: "UT_City");
        }
    }
}
