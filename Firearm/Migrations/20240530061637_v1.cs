using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Firearm.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "civillianPendings",
                columns: table => new
                {
                    CivillianPendingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcadamicStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MartialStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeOfCapital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subcity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kebele = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecificArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phonenumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    homenumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    holder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisteredBodyFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodyResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodySignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodyDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_civillianPendings", x => x.CivillianPendingId);
                });

            migrationBuilder.CreateTable(
                name: "Civillians",
                columns: table => new
                {
                    CivillianId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcadamicStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MartialStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeOfCapital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subcity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kebele = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecificArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phonenumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    homenumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    holder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisteredBodyFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodyResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodySignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    DestructionRequestedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonForDestruction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorizedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorizationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDestroyed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    holder = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destroyeds", x => x.DestroyedId);
                });

            migrationBuilder.CreateTable(
                name: "distructionPendings",
                columns: table => new
                {
                    distructionPendingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestructionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DestructionRequestedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonForDestruction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorizedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorizationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDestroyed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    holder = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_distructionPendings", x => x.distructionPendingId);
                });

            migrationBuilder.CreateTable(
                name: "firearmHolders",
                columns: table => new
                {
                    DestroyedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    holder = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_firearmHolders", x => x.DestroyedId);
                });

            migrationBuilder.CreateTable(
                name: "Firearms",
                columns: table => new
                {
                    firearmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirearmReturnedTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorizedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorizedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReasonToReturn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    holder = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    CountryOfOrigin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicensedCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LevelOfService = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subcity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kebele = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecificArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    registeredResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisteredBodyFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodyResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodySignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    holder = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hmts", x => x.firearmId);
                });

            migrationBuilder.CreateTable(
                name: "hmtsPendings",
                columns: table => new
                {
                    hmtsPendingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryOfOrigin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicensedCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LevelOfService = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subcity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kebele = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecificArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    registeredResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisteredBodyFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodyResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodySignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    holder = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hmtsPendings", x => x.hmtsPendingId);
                });

            migrationBuilder.CreateTable(
                name: "iofcPendings",
                columns: table => new
                {
                    iofcPendingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CandidateCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EvidenceOfMedical = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonHeCame = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountryOfResidence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subcity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kebele = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecificArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    registeredResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisteredBodyFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodyResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodySignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    holder = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iofcPendings", x => x.iofcPendingId);
                });

            migrationBuilder.CreateTable(
                name: "iofcs",
                columns: table => new
                {
                    iofcPendingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CandidateCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EvidenceOfMedical = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonHeCame = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountryOfResidence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subcity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kebele = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecificArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    registeredResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisteredBodyFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodyResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodySignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    holder = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iofcs", x => x.iofcPendingId);
                });

            migrationBuilder.CreateTable(
                name: "Losses",
                columns: table => new
                {
                    LossId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FpId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    holder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateLost = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Losses", x => x.LossId);
                });

            migrationBuilder.CreateTable(
                name: "losspendings",
                columns: table => new
                {
                    lossPendingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FpId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    holder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateLost = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_losspendings", x => x.lossPendingId);
                });

            migrationBuilder.CreateTable(
                name: "notifications",
                columns: table => new
                {
                    NotificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    holder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    SentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    store = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notifications", x => x.NotificationId);
                });

            migrationBuilder.CreateTable(
                name: "officerPendings",
                columns: table => new
                {
                    OfficerPendingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FpId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Holder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisteredBodyFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodyResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodySignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodyDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_officerPendings", x => x.OfficerPendingId);
                });

            migrationBuilder.CreateTable(
                name: "Officers",
                columns: table => new
                {
                    OfficerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FpId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Holder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisteredBodyFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodyResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodySignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    NameOfOrganisation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeOfCapital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subcity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kebele = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecificArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    registeredResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisteredBodyFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodyResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodySignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    holder = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poages", x => x.poagId);
                });

            migrationBuilder.CreateTable(
                name: "poagPendings",
                columns: table => new
                {
                    poagOfficerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfOrganisation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeOfCapital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subcity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kebele = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecificArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    registeredResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisteredBodyFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodyResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodySignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredBodyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    holder = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_poagPendings", x => x.poagOfficerId);
                });

            migrationBuilder.CreateTable(
                name: "recoverPendings",
                columns: table => new
                {
                    recoverPendingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirearmReturnedTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorizedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorizedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReasonToReturn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFirearm = table.Column<bool>(type: "bit", nullable: false),
                    DateMarked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmMechanism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirearmCalibre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MagazineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Store = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recoverPendings", x => x.recoverPendingId);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nameid = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EFPID = table.Column<int>(type: "int", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension = table.Column<int>(type: "int", nullable: false),
                    Mobile = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "withdrawals",
                columns: table => new
                {
                    withdrawId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManufacturerSerial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WithdrawalDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_withdrawals", x => x.withdrawId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "civillianPendings");

            migrationBuilder.DropTable(
                name: "Civillians");

            migrationBuilder.DropTable(
                name: "Destroyeds");

            migrationBuilder.DropTable(
                name: "distructionPendings");

            migrationBuilder.DropTable(
                name: "firearmHolders");

            migrationBuilder.DropTable(
                name: "Firearms");

            migrationBuilder.DropTable(
                name: "hmts");

            migrationBuilder.DropTable(
                name: "hmtsPendings");

            migrationBuilder.DropTable(
                name: "iofcPendings");

            migrationBuilder.DropTable(
                name: "iofcs");

            migrationBuilder.DropTable(
                name: "Losses");

            migrationBuilder.DropTable(
                name: "losspendings");

            migrationBuilder.DropTable(
                name: "notifications");

            migrationBuilder.DropTable(
                name: "officerPendings");

            migrationBuilder.DropTable(
                name: "Officers");

            migrationBuilder.DropTable(
                name: "Poages");

            migrationBuilder.DropTable(
                name: "poagPendings");

            migrationBuilder.DropTable(
                name: "recoverPendings");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "withdrawals");
        }
    }
}
