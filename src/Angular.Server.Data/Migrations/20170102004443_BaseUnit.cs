using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Angular.Server.Data.Migrations
{
    public partial class BaseUnit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Units",
                table: "Units");

            migrationBuilder.RenameTable(
                name: "Units",
                newName: "BaseUnits");

            migrationBuilder.AddColumn<double>(
                name: "Area",
                table: "BaseUnits",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Volume",
                table: "BaseUnits",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaseUnits",
                table: "BaseUnits",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ElectricalDeviceType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: true),
                    TypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricalDeviceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ElectricalSystemType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricalSystemType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ElectricalSystem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BaseUnitId = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    ElectricalSystemTypeId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricalSystem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectricalSystem_BaseUnits_BaseUnitId",
                        column: x => x.BaseUnitId,
                        principalTable: "BaseUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElectricalSystem_ElectricalSystemType_ElectricalSystemTypeId",
                        column: x => x.ElectricalSystemTypeId,
                        principalTable: "ElectricalSystemType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BatteryPackModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Capacity = table.Column<int>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: true),
                    ManufacturerId = table.Column<int>(nullable: false),
                    ModelName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatteryPackModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BatteryPackModel_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElectricalDeviceModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ElectricalDeviceTypeId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: true),
                    ManufacturerId = table.Column<int>(nullable: false),
                    MaxValue = table.Column<double>(nullable: false),
                    MeasuringUnit = table.Column<string>(nullable: true),
                    MinValue = table.Column<double>(nullable: false),
                    ModelIdentifier = table.Column<string>(nullable: true),
                    ModelName = table.Column<string>(nullable: true),
                    PowerAtLowestUnitLevel = table.Column<double>(nullable: false),
                    PowerPerStep = table.Column<double>(nullable: false),
                    Step = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricalDeviceModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectricalDeviceModel_ElectricalDeviceType_ElectricalDeviceTypeId",
                        column: x => x.ElectricalDeviceTypeId,
                        principalTable: "ElectricalDeviceType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElectricalDeviceModel_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BatteryPack",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BatteryPackModelId = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    CurrentCharge = table.Column<double>(nullable: false),
                    DeletedBy = table.Column<string>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatteryPack", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BatteryPack_BatteryPackModel_BatteryPackModelId",
                        column: x => x.BatteryPackModelId,
                        principalTable: "BatteryPackModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElectricalDevice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    ElectricalDeviceModelId = table.Column<int>(nullable: false),
                    ElectricalSystemId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: true),
                    ManufacturingDate = table.Column<DateTime>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricalDevice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectricalDevice_ElectricalDeviceModel_ElectricalDeviceModelId",
                        column: x => x.ElectricalDeviceModelId,
                        principalTable: "ElectricalDeviceModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElectricalDevice_ElectricalSystem_ElectricalSystemId",
                        column: x => x.ElectricalSystemId,
                        principalTable: "ElectricalSystem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BatteryPack_BatteryPackModelId",
                table: "BatteryPack",
                column: "BatteryPackModelId");

            migrationBuilder.CreateIndex(
                name: "IX_BatteryPackModel_ManufacturerId",
                table: "BatteryPackModel",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricalDevice_ElectricalDeviceModelId",
                table: "ElectricalDevice",
                column: "ElectricalDeviceModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricalDevice_ElectricalSystemId",
                table: "ElectricalDevice",
                column: "ElectricalSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricalDeviceModel_ElectricalDeviceTypeId",
                table: "ElectricalDeviceModel",
                column: "ElectricalDeviceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricalDeviceModel_ManufacturerId",
                table: "ElectricalDeviceModel",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricalSystem_BaseUnitId",
                table: "ElectricalSystem",
                column: "BaseUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricalSystem_ElectricalSystemTypeId",
                table: "ElectricalSystem",
                column: "ElectricalSystemTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BatteryPack");

            migrationBuilder.DropTable(
                name: "ElectricalDevice");

            migrationBuilder.DropTable(
                name: "BatteryPackModel");

            migrationBuilder.DropTable(
                name: "ElectricalDeviceModel");

            migrationBuilder.DropTable(
                name: "ElectricalSystem");

            migrationBuilder.DropTable(
                name: "ElectricalDeviceType");

            migrationBuilder.DropTable(
                name: "Manufacturer");

            migrationBuilder.DropTable(
                name: "ElectricalSystemType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BaseUnits",
                table: "BaseUnits");

            migrationBuilder.DropColumn(
                name: "Area",
                table: "BaseUnits");

            migrationBuilder.DropColumn(
                name: "Volume",
                table: "BaseUnits");

            migrationBuilder.RenameTable(
                name: "BaseUnits",
                newName: "Units");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Units",
                table: "Units",
                column: "Id");
        }
    }
}
