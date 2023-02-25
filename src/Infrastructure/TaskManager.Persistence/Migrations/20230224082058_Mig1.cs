using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskManager.Persistence.Migrations
{
    public partial class Mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    IdCity = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTown = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChangedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChangedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SH_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SH_User_SH_User_CreatedId",
                        column: x => x.CreatedId,
                        principalTable: "SH_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                    CreatedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChangedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChangedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_SH_User_CreatedId",
                        column: x => x.CreatedId,
                        principalTable: "SH_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    CreatedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChangedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChangedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UT_Country", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UT_Country_SH_User_CreatedId",
                        column: x => x.CreatedId,
                        principalTable: "SH_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CreatedId",
                table: "Products",
                column: "CreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_SH_User_CreatedId",
                table: "SH_User",
                column: "CreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_UT_Country_CreatedId",
                table: "UT_Country",
                column: "CreatedId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "UT_Country");

            migrationBuilder.DropTable(
                name: "SH_User");
        }
    }
}
