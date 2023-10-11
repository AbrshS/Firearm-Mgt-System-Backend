﻿// <auto-generated />
using System;
using Firearm.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Firearm.Migrations
{
    [DbContext(typeof(FirearmDbContext))]
    partial class FirearmDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Firearm.Controllers.Models.Civillian", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CivillianId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AcadamicStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdditionalComment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateMarked")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmCalibre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmMechanism")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFirearm")
                        .HasColumnType("bit");

                    b.Property<string>("Kebele")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MagazineCapacity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManufacturerSerial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MarkedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MartialStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisteredBodyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegisteredBodyFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredBodyResponsibility")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredBodySignature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisteredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegisteredFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredPosition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredSignature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeOfCapital")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecificArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Store")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subcity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YearManufacture")
                        .HasColumnType("datetime2");

                    b.Property<string>("homenumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phonenumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Civillians");
                });

            modelBuilder.Entity("Firearm.Controllers.Models.Destroyed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DestroyedId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdditionalComment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AuthorizationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AuthorizedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateMarked")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DestructionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DestructionRequestedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmCalibre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmMechanism")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFirearm")
                        .HasColumnType("bit");

                    b.Property<string>("MagazineCapacity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManufacturerSerial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MarkedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReasonForDestruction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Store")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YearManufacture")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Destroyeds");
                });

            modelBuilder.Entity("Firearm.Controllers.Models.Firearm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("firearmId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdditionalComment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorizedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AuthorizedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateMarked")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirearmCalibre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmMechanism")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmReturnedTo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFirearm")
                        .HasColumnType("bit");

                    b.Property<string>("MagazineCapacity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManufacturerSerial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MarkedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReasonToReturn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReportedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Store")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YearManufacture")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Firearms");
                });

            modelBuilder.Entity("Firearm.Controllers.Models.Hmts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("firearmId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdditionalComment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryOfOrigin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateMarked")
                        .HasColumnType("datetime2");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmCalibre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmMechanism")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFirearm")
                        .HasColumnType("bit");

                    b.Property<string>("LevelOfService")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicensedCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MagazineCapacity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManufacturerSerial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MarkedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisteredBodyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegisteredBodyFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredBodyResponsibility")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredBodySignature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisteredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegisteredFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredPosition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredSignature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecificArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Store")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subcity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YearManufacture")
                        .HasColumnType("datetime2");

                    b.Property<string>("kebele")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("registeredResponsibility")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("hmts");
                });

            modelBuilder.Entity("Firearm.Controllers.Models.Iofc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("poagId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdditionalComment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CandidateCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ComingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CountryOfResidence")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateMarked")
                        .HasColumnType("datetime2");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EvidenceOfMedical")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmCalibre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmMechanism")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFirearm")
                        .HasColumnType("bit");

                    b.Property<string>("MagazineCapacity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManufacturerSerial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MarkedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReasonHeCame")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisteredBodyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegisteredBodyFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredBodyResponsibility")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredBodySignature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisteredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegisteredFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredPosition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredSignature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecificArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Store")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subcity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YearManufacture")
                        .HasColumnType("datetime2");

                    b.Property<string>("kebele")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("registeredResponsibility")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("iofcs");
                });

            modelBuilder.Entity("Firearm.Controllers.Models.Loss", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("LossId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdditionalComment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateMarked")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirearmCalibre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmMechanism")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FpId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFirearm")
                        .HasColumnType("bit");

                    b.Property<string>("Lholder")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MagazineCapacity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManufacturerSerial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MarkedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReportedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Store")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YearManufacture")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Losses");
                });

            modelBuilder.Entity("Firearm.Controllers.Models.Officer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OfficerId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdditionalComment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateMarked")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmCalibre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmMechanism")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FpId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFirearm")
                        .HasColumnType("bit");

                    b.Property<string>("MagazineCapacity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManufacturerSerial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MarkedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oholder")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisteredBodyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegisteredBodyFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredBodyResponsibility")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredBodySignature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisteredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegisteredEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredPosition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredSignature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Store")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YearManufacture")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Officers");
                });

            modelBuilder.Entity("Firearm.Controllers.Models.Poag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("poagId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdditionalComment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateMarked")
                        .HasColumnType("datetime2");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmCalibre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmMechanism")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirearmType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFirearm")
                        .HasColumnType("bit");

                    b.Property<string>("MagazineCapacity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManufacturerSerial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MarkedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameOfOrganisation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisteredBodyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegisteredBodyFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredBodyResponsibility")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredBodySignature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisteredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegisteredFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredPosition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredSignature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeOfCapital")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecificArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Store")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subcity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YearManufacture")
                        .HasColumnType("datetime2");

                    b.Property<string>("kebele")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("registeredResponsibility")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sector")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Poages");
                });
#pragma warning restore 612, 618
        }
    }
}
