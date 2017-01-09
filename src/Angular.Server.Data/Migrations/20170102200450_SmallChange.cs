using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Angular.Server.Data.Migrations
{
    public partial class SmallChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BatteryPack_BatteryPackModel_BatteryPackModelId",
                table: "BatteryPack");

            migrationBuilder.DropForeignKey(
                name: "FK_BatteryPackModel_Manufacturer_ManufacturerId",
                table: "BatteryPackModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricalDevice_ElectricalDeviceModel_ElectricalDeviceModelId",
                table: "ElectricalDevice");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricalDevice_ElectricalSystem_ElectricalSystemId",
                table: "ElectricalDevice");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricalDeviceModel_ElectricalDeviceType_ElectricalDeviceTypeId",
                table: "ElectricalDeviceModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricalDeviceModel_Manufacturer_ManufacturerId",
                table: "ElectricalDeviceModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricalSystem_BaseUnits_BaseUnitId",
                table: "ElectricalSystem");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricalSystem_ElectricalSystemType_ElectricalSystemTypeId",
                table: "ElectricalSystem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Manufacturer",
                table: "Manufacturer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElectricalSystemType",
                table: "ElectricalSystemType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElectricalSystem",
                table: "ElectricalSystem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElectricalDeviceType",
                table: "ElectricalDeviceType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElectricalDeviceModel",
                table: "ElectricalDeviceModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElectricalDevice",
                table: "ElectricalDevice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BatteryPackModel",
                table: "BatteryPackModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BatteryPack",
                table: "BatteryPack");

            migrationBuilder.RenameTable(
                name: "Manufacturer",
                newName: "Manufacturers");

            migrationBuilder.RenameTable(
                name: "ElectricalSystemType",
                newName: "ElectricalSystemTypes");

            migrationBuilder.RenameTable(
                name: "ElectricalSystem",
                newName: "ElectricalSystems");

            migrationBuilder.RenameTable(
                name: "ElectricalDeviceType",
                newName: "ElectricalDeviceTypes");

            migrationBuilder.RenameTable(
                name: "ElectricalDeviceModel",
                newName: "ElectricalDeviceModels");

            migrationBuilder.RenameTable(
                name: "ElectricalDevice",
                newName: "ElectricalDevices");

            migrationBuilder.RenameTable(
                name: "BatteryPackModel",
                newName: "BatteryPackModels");

            migrationBuilder.RenameTable(
                name: "BatteryPack",
                newName: "BatteryPacks");

            migrationBuilder.RenameIndex(
                name: "IX_ElectricalSystem_ElectricalSystemTypeId",
                table: "ElectricalSystems",
                newName: "IX_ElectricalSystems_ElectricalSystemTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ElectricalSystem_BaseUnitId",
                table: "ElectricalSystems",
                newName: "IX_ElectricalSystems_BaseUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_ElectricalDeviceModel_ManufacturerId",
                table: "ElectricalDeviceModels",
                newName: "IX_ElectricalDeviceModels_ManufacturerId");

            migrationBuilder.RenameIndex(
                name: "IX_ElectricalDeviceModel_ElectricalDeviceTypeId",
                table: "ElectricalDeviceModels",
                newName: "IX_ElectricalDeviceModels_ElectricalDeviceTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ElectricalDevice_ElectricalSystemId",
                table: "ElectricalDevices",
                newName: "IX_ElectricalDevices_ElectricalSystemId");

            migrationBuilder.RenameIndex(
                name: "IX_ElectricalDevice_ElectricalDeviceModelId",
                table: "ElectricalDevices",
                newName: "IX_ElectricalDevices_ElectricalDeviceModelId");

            migrationBuilder.RenameIndex(
                name: "IX_BatteryPackModel_ManufacturerId",
                table: "BatteryPackModels",
                newName: "IX_BatteryPackModels_ManufacturerId");

            migrationBuilder.RenameIndex(
                name: "IX_BatteryPack_BatteryPackModelId",
                table: "BatteryPacks",
                newName: "IX_BatteryPacks_BatteryPackModelId");

            migrationBuilder.AddColumn<double>(
                name: "MeasuringUnitCurrentLevel",
                table: "ElectricalDevices",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manufacturers",
                table: "Manufacturers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElectricalSystemTypes",
                table: "ElectricalSystemTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElectricalSystems",
                table: "ElectricalSystems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElectricalDeviceTypes",
                table: "ElectricalDeviceTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElectricalDeviceModels",
                table: "ElectricalDeviceModels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElectricalDevices",
                table: "ElectricalDevices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BatteryPackModels",
                table: "BatteryPackModels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BatteryPacks",
                table: "BatteryPacks",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "BatteryPackChargeHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChargeLevel = table.Column<double>(nullable: false),
                    DateOfMeasure = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatteryPackChargeHistories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ElectricalDevicesConsumptionHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateOfMeasure = table.Column<DateTime>(nullable: false),
                    ElectricalDeviceId = table.Column<int>(nullable: false),
                    PowerConsumptionRate = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricalDevicesConsumptionHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectricalDevicesConsumptionHistories_ElectricalDevices_ElectricalDeviceId",
                        column: x => x.ElectricalDeviceId,
                        principalTable: "ElectricalDevices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EnergyGenerators",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    ElectricalDeviceModelId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnergyGenerators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnergyGenerators_ElectricalDeviceModels_ElectricalDeviceModelId",
                        column: x => x.ElectricalDeviceModelId,
                        principalTable: "ElectricalDeviceModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EnergyGeneratorProductionHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateOfMeasure = table.Column<DateTime>(nullable: false),
                    EnergyGeneratorId = table.Column<int>(nullable: false),
                    PowerProductionRate = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnergyGeneratorProductionHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnergyGeneratorProductionHistories_EnergyGenerators_EnergyGeneratorId",
                        column: x => x.EnergyGeneratorId,
                        principalTable: "EnergyGenerators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElectricalDevicesConsumptionHistories_ElectricalDeviceId",
                table: "ElectricalDevicesConsumptionHistories",
                column: "ElectricalDeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_EnergyGenerators_ElectricalDeviceModelId",
                table: "EnergyGenerators",
                column: "ElectricalDeviceModelId");

            migrationBuilder.CreateIndex(
                name: "IX_EnergyGeneratorProductionHistories_EnergyGeneratorId",
                table: "EnergyGeneratorProductionHistories",
                column: "EnergyGeneratorId");

            migrationBuilder.AddForeignKey(
                name: "FK_BatteryPacks_BatteryPackModels_BatteryPackModelId",
                table: "BatteryPacks",
                column: "BatteryPackModelId",
                principalTable: "BatteryPackModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BatteryPackModels_Manufacturers_ManufacturerId",
                table: "BatteryPackModels",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricalDevices_ElectricalDeviceModels_ElectricalDeviceModelId",
                table: "ElectricalDevices",
                column: "ElectricalDeviceModelId",
                principalTable: "ElectricalDeviceModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricalDevices_ElectricalSystems_ElectricalSystemId",
                table: "ElectricalDevices",
                column: "ElectricalSystemId",
                principalTable: "ElectricalSystems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricalDeviceModels_ElectricalDeviceTypes_ElectricalDeviceTypeId",
                table: "ElectricalDeviceModels",
                column: "ElectricalDeviceTypeId",
                principalTable: "ElectricalDeviceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricalDeviceModels_Manufacturers_ManufacturerId",
                table: "ElectricalDeviceModels",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricalSystems_BaseUnits_BaseUnitId",
                table: "ElectricalSystems",
                column: "BaseUnitId",
                principalTable: "BaseUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricalSystems_ElectricalSystemTypes_ElectricalSystemTypeId",
                table: "ElectricalSystems",
                column: "ElectricalSystemTypeId",
                principalTable: "ElectricalSystemTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BatteryPacks_BatteryPackModels_BatteryPackModelId",
                table: "BatteryPacks");

            migrationBuilder.DropForeignKey(
                name: "FK_BatteryPackModels_Manufacturers_ManufacturerId",
                table: "BatteryPackModels");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricalDevices_ElectricalDeviceModels_ElectricalDeviceModelId",
                table: "ElectricalDevices");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricalDevices_ElectricalSystems_ElectricalSystemId",
                table: "ElectricalDevices");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricalDeviceModels_ElectricalDeviceTypes_ElectricalDeviceTypeId",
                table: "ElectricalDeviceModels");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricalDeviceModels_Manufacturers_ManufacturerId",
                table: "ElectricalDeviceModels");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricalSystems_BaseUnits_BaseUnitId",
                table: "ElectricalSystems");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricalSystems_ElectricalSystemTypes_ElectricalSystemTypeId",
                table: "ElectricalSystems");

            migrationBuilder.DropTable(
                name: "BatteryPackChargeHistories");

            migrationBuilder.DropTable(
                name: "ElectricalDevicesConsumptionHistories");

            migrationBuilder.DropTable(
                name: "EnergyGeneratorProductionHistories");

            migrationBuilder.DropTable(
                name: "EnergyGenerators");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Manufacturers",
                table: "Manufacturers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElectricalSystemTypes",
                table: "ElectricalSystemTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElectricalSystems",
                table: "ElectricalSystems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElectricalDeviceTypes",
                table: "ElectricalDeviceTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElectricalDeviceModels",
                table: "ElectricalDeviceModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElectricalDevices",
                table: "ElectricalDevices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BatteryPackModels",
                table: "BatteryPackModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BatteryPacks",
                table: "BatteryPacks");

            migrationBuilder.DropColumn(
                name: "MeasuringUnitCurrentLevel",
                table: "ElectricalDevices");

            migrationBuilder.RenameTable(
                name: "Manufacturers",
                newName: "Manufacturer");

            migrationBuilder.RenameTable(
                name: "ElectricalSystemTypes",
                newName: "ElectricalSystemType");

            migrationBuilder.RenameTable(
                name: "ElectricalSystems",
                newName: "ElectricalSystem");

            migrationBuilder.RenameTable(
                name: "ElectricalDeviceTypes",
                newName: "ElectricalDeviceType");

            migrationBuilder.RenameTable(
                name: "ElectricalDeviceModels",
                newName: "ElectricalDeviceModel");

            migrationBuilder.RenameTable(
                name: "ElectricalDevices",
                newName: "ElectricalDevice");

            migrationBuilder.RenameTable(
                name: "BatteryPackModels",
                newName: "BatteryPackModel");

            migrationBuilder.RenameTable(
                name: "BatteryPacks",
                newName: "BatteryPack");

            migrationBuilder.RenameIndex(
                name: "IX_ElectricalSystems_ElectricalSystemTypeId",
                table: "ElectricalSystem",
                newName: "IX_ElectricalSystem_ElectricalSystemTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ElectricalSystems_BaseUnitId",
                table: "ElectricalSystem",
                newName: "IX_ElectricalSystem_BaseUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_ElectricalDeviceModels_ManufacturerId",
                table: "ElectricalDeviceModel",
                newName: "IX_ElectricalDeviceModel_ManufacturerId");

            migrationBuilder.RenameIndex(
                name: "IX_ElectricalDeviceModels_ElectricalDeviceTypeId",
                table: "ElectricalDeviceModel",
                newName: "IX_ElectricalDeviceModel_ElectricalDeviceTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ElectricalDevices_ElectricalSystemId",
                table: "ElectricalDevice",
                newName: "IX_ElectricalDevice_ElectricalSystemId");

            migrationBuilder.RenameIndex(
                name: "IX_ElectricalDevices_ElectricalDeviceModelId",
                table: "ElectricalDevice",
                newName: "IX_ElectricalDevice_ElectricalDeviceModelId");

            migrationBuilder.RenameIndex(
                name: "IX_BatteryPackModels_ManufacturerId",
                table: "BatteryPackModel",
                newName: "IX_BatteryPackModel_ManufacturerId");

            migrationBuilder.RenameIndex(
                name: "IX_BatteryPacks_BatteryPackModelId",
                table: "BatteryPack",
                newName: "IX_BatteryPack_BatteryPackModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manufacturer",
                table: "Manufacturer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElectricalSystemType",
                table: "ElectricalSystemType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElectricalSystem",
                table: "ElectricalSystem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElectricalDeviceType",
                table: "ElectricalDeviceType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElectricalDeviceModel",
                table: "ElectricalDeviceModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElectricalDevice",
                table: "ElectricalDevice",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BatteryPackModel",
                table: "BatteryPackModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BatteryPack",
                table: "BatteryPack",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BatteryPack_BatteryPackModel_BatteryPackModelId",
                table: "BatteryPack",
                column: "BatteryPackModelId",
                principalTable: "BatteryPackModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BatteryPackModel_Manufacturer_ManufacturerId",
                table: "BatteryPackModel",
                column: "ManufacturerId",
                principalTable: "Manufacturer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricalDevice_ElectricalDeviceModel_ElectricalDeviceModelId",
                table: "ElectricalDevice",
                column: "ElectricalDeviceModelId",
                principalTable: "ElectricalDeviceModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricalDevice_ElectricalSystem_ElectricalSystemId",
                table: "ElectricalDevice",
                column: "ElectricalSystemId",
                principalTable: "ElectricalSystem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricalDeviceModel_ElectricalDeviceType_ElectricalDeviceTypeId",
                table: "ElectricalDeviceModel",
                column: "ElectricalDeviceTypeId",
                principalTable: "ElectricalDeviceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricalDeviceModel_Manufacturer_ManufacturerId",
                table: "ElectricalDeviceModel",
                column: "ManufacturerId",
                principalTable: "Manufacturer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricalSystem_BaseUnits_BaseUnitId",
                table: "ElectricalSystem",
                column: "BaseUnitId",
                principalTable: "BaseUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricalSystem_ElectricalSystemType_ElectricalSystemTypeId",
                table: "ElectricalSystem",
                column: "ElectricalSystemTypeId",
                principalTable: "ElectricalSystemType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
