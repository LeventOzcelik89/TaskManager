using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "varchar(100)", nullable: true),
                    LastName = table.Column<string>(type: "varchar(100)", nullable: true),
                    Email = table.Column<string>(type: "varchar(250)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CellPhone = table.Column<string>(type: "varchar(10)", nullable: true),
                    IdentityNumber = table.Column<string>(type: "varchar(11)", nullable: true),
                    Password = table.Column<string>(type: "varchar(250)", nullable: true),
                    TownId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: true),
                    UT_City_Name = table.Column<string>(type: "varchar(100)", nullable: true),
                    PlateNumber = table.Column<string>(type: "varchar(2)", nullable: true),
                    PhoneCode = table.Column<string>(type: "varchar(10)", nullable: true),
                    UT_Country_Name = table.Column<string>(type: "varchar(100)", nullable: true),
                    UT_Town_Name = table.Column<string>(type: "varchar(100)", nullable: true),
                    UT_Town_CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_CityId",
                        column: x => x.CityId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_TownId",
                        column: x => x.TownId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_UT_Town_CityId",
                        column: x => x.UT_Town_CityId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_CityId",
                table: "BaseEntity",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_TownId",
                table: "BaseEntity",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_UT_Town_CityId",
                table: "BaseEntity",
                column: "UT_Town_CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseEntity");
        }
    }
}
