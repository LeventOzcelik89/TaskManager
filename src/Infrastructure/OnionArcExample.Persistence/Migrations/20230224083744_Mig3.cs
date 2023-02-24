using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnionArcExample.Persistence.Migrations
{
    public partial class Mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SH_User_CreatedId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_SH_User_SH_User_CreatedId",
                table: "SH_User");

            migrationBuilder.DropForeignKey(
                name: "FK_UT_Country_SH_User_CreatedId",
                table: "UT_Country");

            migrationBuilder.DropIndex(
                name: "IX_UT_Country_CreatedId",
                table: "UT_Country");

            migrationBuilder.DropIndex(
                name: "IX_SH_User_CreatedId",
                table: "SH_User");

            migrationBuilder.DropIndex(
                name: "IX_Products_CreatedId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ChangedId",
                table: "UT_Country");

            migrationBuilder.DropColumn(
                name: "ChangedTime",
                table: "UT_Country");

            migrationBuilder.DropColumn(
                name: "ChangedId",
                table: "SH_User");

            migrationBuilder.DropColumn(
                name: "ChangedTime",
                table: "SH_User");

            migrationBuilder.DropColumn(
                name: "ChangedId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ChangedTime",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "IdTown",
                table: "SH_User",
                newName: "TownId");

            migrationBuilder.RenameColumn(
                name: "IdCity",
                table: "SH_User",
                newName: "CityId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SH_User_UT_City_CityId",
                table: "SH_User",
                column: "CityId",
                principalTable: "UT_City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SH_User_UT_Town_TownId",
                table: "SH_User",
                column: "TownId",
                principalTable: "UT_Town",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SH_User_UT_City_CityId",
                table: "SH_User");

            migrationBuilder.DropForeignKey(
                name: "FK_SH_User_UT_Town_TownId",
                table: "SH_User");

            migrationBuilder.DropTable(
                name: "UT_Town");

            migrationBuilder.DropTable(
                name: "UT_City");

            migrationBuilder.DropIndex(
                name: "IX_SH_User_CityId",
                table: "SH_User");

            migrationBuilder.DropIndex(
                name: "IX_SH_User_TownId",
                table: "SH_User");

            migrationBuilder.RenameColumn(
                name: "TownId",
                table: "SH_User",
                newName: "IdTown");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "SH_User",
                newName: "IdCity");

            migrationBuilder.AddColumn<Guid>(
                name: "ChangedId",
                table: "UT_Country",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ChangedTime",
                table: "UT_Country",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ChangedId",
                table: "SH_User",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ChangedTime",
                table: "SH_User",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ChangedId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ChangedTime",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UT_Country_CreatedId",
                table: "UT_Country",
                column: "CreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_SH_User_CreatedId",
                table: "SH_User",
                column: "CreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CreatedId",
                table: "Products",
                column: "CreatedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SH_User_CreatedId",
                table: "Products",
                column: "CreatedId",
                principalTable: "SH_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SH_User_SH_User_CreatedId",
                table: "SH_User",
                column: "CreatedId",
                principalTable: "SH_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UT_Country_SH_User_CreatedId",
                table: "UT_Country",
                column: "CreatedId",
                principalTable: "SH_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
