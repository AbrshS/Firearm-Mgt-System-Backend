using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Firearm.Migrations
{
    /// <inheritdoc />
    public partial class initialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Firearms",
                columns: table => new
                {
                    firearmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    AssignedSerial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearManufacture = table.Column<int>(type: "int", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firearms", x => x.firearmId);
                });

            migrationBuilder.CreateTable(
                name: "Officers",
                columns: table => new
                {
                    OfficerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearManufacture = table.Column<int>(type: "int", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredPosition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredSignature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisteredBodyFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredBodyResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredBodySignature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredBodyDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Officers", x => x.OfficerId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Firearms");

            migrationBuilder.DropTable(
                name: "Officers");
        }
    }
}
