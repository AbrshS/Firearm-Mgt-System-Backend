using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Firearm.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Firearms");
        }
    }
}
