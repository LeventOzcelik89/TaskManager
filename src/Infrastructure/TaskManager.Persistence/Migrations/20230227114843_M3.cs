using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class M3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UT_Town_UT_City_CityId",
                table: "UT_Town");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SH_User");

            migrationBuilder.DropTable(
                name: "UT_Country");

            migrationBuilder.DropTable(
                name: "UT_City");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UT_Town",
                table: "UT_Town");

            migrationBuilder.RenameTable(
                name: "UT_Town",
                newName: "BaseEntity");

            migrationBuilder.RenameIndex(
                name: "IX_UT_Town_CityId",
                table: "BaseEntity",
                newName: "IX_BaseEntity_CityId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BaseEntity",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "BaseEntity",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CellPhone",
                table: "BaseEntity",
                type: "varchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code2",
                table: "BaseEntity",
                type: "varchar(2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code3",
                table: "BaseEntity",
                type: "varchar(3)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "BaseEntity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "BaseEntity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "BaseEntity",
                type: "varchar(250)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "BaseEntity",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityNumber",
                table: "BaseEntity",
                type: "varchar(11)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsBlocked",
                table: "BaseEntity",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "BaseEntity",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "BaseEntity",
                type: "varchar(250)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneCode",
                table: "BaseEntity",
                type: "varchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlateNumber",
                table: "BaseEntity",
                type: "varchar(2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TownId",
                table: "BaseEntity",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UT_City_Name",
                table: "BaseEntity",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UT_Country_Name",
                table: "BaseEntity",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UT_Country_PhoneCode",
                table: "BaseEntity",
                type: "varchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UT_Town_CityId",
                table: "BaseEntity",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UT_Town_Name",
                table: "BaseEntity",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaseEntity",
                table: "BaseEntity",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_TownId",
                table: "BaseEntity",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_UT_Town_CityId",
                table: "BaseEntity",
                column: "UT_Town_CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_CityId",
                table: "BaseEntity",
                column: "CityId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_TownId",
                table: "BaseEntity",
                column: "TownId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_UT_Town_CityId",
                table: "BaseEntity",
                column: "UT_Town_CityId",
                principalTable: "BaseEntity",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_CityId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_TownId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_UT_Town_CityId",
                table: "BaseEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BaseEntity",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_TownId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_UT_Town_CityId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "CellPhone",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Code2",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Code3",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "IdentityNumber",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "IsBlocked",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "PhoneCode",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "PlateNumber",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "TownId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "UT_City_Name",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "UT_Country_Name",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "UT_Country_PhoneCode",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "UT_Town_CityId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "UT_Town_Name",
                table: "BaseEntity");

            migrationBuilder.RenameTable(
                name: "BaseEntity",
                newName: "UT_Town");

            migrationBuilder.RenameIndex(
                name: "IX_BaseEntity_CityId",
                table: "UT_Town",
                newName: "IX_UT_Town_CityId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UT_Town",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UT_Town",
                table: "UT_Town",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
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
                    CreatedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: true),
                    PhoneCode = table.Column<string>(type: "varchar(10)", nullable: true),
                    PlateNumber = table.Column<string>(type: "varchar(2)", nullable: true)
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
                    CreatedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: true),
                    PhoneCode = table.Column<string>(type: "varchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UT_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SH_User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TownId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CellPhone = table.Column<string>(type: "varchar(10)", nullable: true),
                    CreatedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "varchar(250)", nullable: true),
                    FirstName = table.Column<string>(type: "varchar(100)", nullable: true),
                    IdentityNumber = table.Column<string>(type: "varchar(11)", nullable: true),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: true),
                    LastName = table.Column<string>(type: "varchar(100)", nullable: true),
                    Password = table.Column<string>(type: "varchar(250)", nullable: true)
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

            migrationBuilder.AddForeignKey(
                name: "FK_UT_Town_UT_City_CityId",
                table: "UT_Town",
                column: "CityId",
                principalTable: "UT_City",
                principalColumn: "Id");
        }
    }
}
