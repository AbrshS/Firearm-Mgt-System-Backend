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
                name: "Civillians",
                columns: table => new
                {
                    CivillianId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcadamicStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MartialStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SizeOfCapital = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subcity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kebele = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecificArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassportId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phonenumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    homenumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredPosition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredSignature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisteredBodyFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredBodyResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredBodySignature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredBodyDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Civillians", x => x.CivillianId);
                });

            migrationBuilder.CreateTable(
                name: "Destroyeds",
                columns: table => new
                {
                    DestroyedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestructionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DestructionRequestedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReasonForDestruction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorizedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorizationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destroyeds", x => x.DestroyedId);
                });

            migrationBuilder.CreateTable(
                name: "Firearms",
                columns: table => new
                {
                    firearmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirearmReturnedTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorizedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorizedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReasonToReturn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firearms", x => x.firearmId);
                });

            migrationBuilder.CreateTable(
                name: "hmts",
                columns: table => new
                {
                    firearmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryOfOrigin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicensedCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LevelOfService = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subcity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kebele = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecificArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassportNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredPosition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    registeredResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredSignature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisteredBodyFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredBodyResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredBodySignature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredBodyDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hmts", x => x.firearmId);
                });

            migrationBuilder.CreateTable(
                name: "iofcs",
                columns: table => new
                {
                    poagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CandidateCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EvidenceOfMedical = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassportNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReasonHeCame = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountryOfResidence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subcity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kebele = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecificArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredPosition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    registeredResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredSignature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisteredBodyFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredBodyResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredBodySignature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredBodyDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iofcs", x => x.poagId);
                });

            migrationBuilder.CreateTable(
                name: "Losses",
                columns: table => new
                {
                    LossId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FpId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lholder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Losses", x => x.LossId);
                });

            migrationBuilder.CreateTable(
                name: "Officers",
                columns: table => new
                {
                    OfficerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FpId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oholder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Poages",
                columns: table => new
                {
                    poagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfOrganisation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SizeOfCapital = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subcity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kebele = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecificArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredPosition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    registeredResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredSignature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisteredBodyFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredBodyResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredBodySignature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredBodyDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poages", x => x.poagId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Civillians");

            migrationBuilder.DropTable(
                name: "Destroyeds");

            migrationBuilder.DropTable(
                name: "Firearms");

            migrationBuilder.DropTable(
                name: "hmts");

            migrationBuilder.DropTable(
                name: "iofcs");

            migrationBuilder.DropTable(
                name: "Losses");

            migrationBuilder.DropTable(
                name: "Officers");

            migrationBuilder.DropTable(
                name: "Poages");
        }
    }
}
