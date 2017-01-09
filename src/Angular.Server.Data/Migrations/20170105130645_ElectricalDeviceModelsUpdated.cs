using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Angular.Server.Data.Migrations
{
    public partial class ElectricalDeviceModelsUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BatteryPacks_BatteryPackModels_BatteryPackModelId",
                table: "BatteryPacks");

            migrationBuilder.DropTable(
                name: "BatteryPackModels");

            migrationBuilder.RenameColumn(
                name: "BatteryPackModelId",
                table: "BatteryPacks",
                newName: "ElectricalDeviceModelId");

            migrationBuilder.RenameIndex(
                name: "IX_BatteryPacks_BatteryPackModelId",
                table: "BatteryPacks",
                newName: "IX_BatteryPacks_ElectricalDeviceModelId");

            migrationBuilder.AddColumn<string>(
                name: "SerailNumber",
                table: "EnergyGenerators",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "ElectricalDeviceModels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SerialNumber",
                table: "BatteryPacks",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BatteryPacks_ElectricalDeviceModels_ElectricalDeviceModelId",
                table: "BatteryPacks",
                column: "ElectricalDeviceModelId",
                principalTable: "ElectricalDeviceModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BatteryPacks_ElectricalDeviceModels_ElectricalDeviceModelId",
                table: "BatteryPacks");

            migrationBuilder.DropColumn(
                name: "SerailNumber",
                table: "EnergyGenerators");

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "ElectricalDeviceModels");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "BatteryPacks");

            migrationBuilder.RenameColumn(
                name: "ElectricalDeviceModelId",
                table: "BatteryPacks",
                newName: "BatteryPackModelId");

            migrationBuilder.RenameIndex(
                name: "IX_BatteryPacks_ElectricalDeviceModelId",
                table: "BatteryPacks",
                newName: "IX_BatteryPacks_BatteryPackModelId");

            migrationBuilder.CreateTable(
                name: "BatteryPackModels",
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
                    table.PrimaryKey("PK_BatteryPackModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BatteryPackModels_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BatteryPackModels_ManufacturerId",
                table: "BatteryPackModels",
                column: "ManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_BatteryPacks_BatteryPackModels_BatteryPackModelId",
                table: "BatteryPacks",
                column: "BatteryPackModelId",
                principalTable: "BatteryPackModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
