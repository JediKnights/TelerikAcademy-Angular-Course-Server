using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Angular.Server.Data;

namespace Angular.Server.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170102004443_BaseUnit")]
    partial class BaseUnit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Angular.Server.Models.DomainModels.BaseUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Area");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastUpdatedOn");

                    b.Property<string>("Name");

                    b.Property<double>("Volume");

                    b.HasKey("Id");

                    b.ToTable("BaseUnits");
                });

            modelBuilder.Entity("Angular.Server.Models.DomainModels.BatteryPack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BatteryPackModelId");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<double>("CurrentCharge");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastUpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("BatteryPackModelId");

                    b.ToTable("BatteryPack");
                });

            modelBuilder.Entity("Angular.Server.Models.DomainModels.BatteryPackModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Capacity");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastUpdatedOn");

                    b.Property<int>("ManufacturerId");

                    b.Property<string>("ModelName");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("BatteryPackModel");
                });

            modelBuilder.Entity("Angular.Server.Models.DomainModels.ElectricalDevice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<int>("ElectricalDeviceModelId");

                    b.Property<int>("ElectricalSystemId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastUpdatedOn");

                    b.Property<DateTime>("ManufacturingDate");

                    b.Property<string>("SerialNumber");

                    b.HasKey("Id");

                    b.HasIndex("ElectricalDeviceModelId");

                    b.HasIndex("ElectricalSystemId");

                    b.ToTable("ElectricalDevice");
                });

            modelBuilder.Entity("Angular.Server.Models.DomainModels.ElectricalDeviceModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<string>("Description");

                    b.Property<int>("ElectricalDeviceTypeId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastUpdatedOn");

                    b.Property<int>("ManufacturerId");

                    b.Property<double>("MaxValue");

                    b.Property<string>("MeasuringUnit");

                    b.Property<double>("MinValue");

                    b.Property<string>("ModelIdentifier");

                    b.Property<string>("ModelName");

                    b.Property<double>("PowerAtLowestUnitLevel");

                    b.Property<double>("PowerPerStep");

                    b.Property<double>("Step");

                    b.HasKey("Id");

                    b.HasIndex("ElectricalDeviceTypeId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("ElectricalDeviceModel");
                });

            modelBuilder.Entity("Angular.Server.Models.DomainModels.ElectricalDeviceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastUpdatedOn");

                    b.Property<string>("TypeName");

                    b.HasKey("Id");

                    b.ToTable("ElectricalDeviceType");
                });

            modelBuilder.Entity("Angular.Server.Models.DomainModels.ElectricalSystem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BaseUnitId");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<int>("ElectricalSystemTypeId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastUpdatedOn");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("BaseUnitId");

                    b.HasIndex("ElectricalSystemTypeId");

                    b.ToTable("ElectricalSystem");
                });

            modelBuilder.Entity("Angular.Server.Models.DomainModels.ElectricalSystemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastUpdatedOn");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ElectricalSystemType");
                });

            modelBuilder.Entity("Angular.Server.Models.DomainModels.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastUpdatedOn");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Manufacturer");
                });

            modelBuilder.Entity("Angular.Server.Models.DomainModels.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastName");

                    b.Property<DateTime?>("LastUpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Angular.Server.Models.IdentityModels.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastUpdatedOn");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Angular.Server.Models.DomainModels.BatteryPack", b =>
                {
                    b.HasOne("Angular.Server.Models.DomainModels.BatteryPackModel", "BatteryPackModel")
                        .WithMany("BatteryPacks")
                        .HasForeignKey("BatteryPackModelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Angular.Server.Models.DomainModels.BatteryPackModel", b =>
                {
                    b.HasOne("Angular.Server.Models.DomainModels.Manufacturer", "Manufacturer")
                        .WithMany("BatteryPackModels")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Angular.Server.Models.DomainModels.ElectricalDevice", b =>
                {
                    b.HasOne("Angular.Server.Models.DomainModels.ElectricalDeviceModel", "ElectricalDeviceModel")
                        .WithMany("ElectricalDevices")
                        .HasForeignKey("ElectricalDeviceModelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Angular.Server.Models.DomainModels.ElectricalSystem", "ElectricalSystem")
                        .WithMany("ElectricalDevices")
                        .HasForeignKey("ElectricalSystemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Angular.Server.Models.DomainModels.ElectricalDeviceModel", b =>
                {
                    b.HasOne("Angular.Server.Models.DomainModels.ElectricalDeviceType", "ElectricalDeviceType")
                        .WithMany("ElectricalDeviceModels")
                        .HasForeignKey("ElectricalDeviceTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Angular.Server.Models.DomainModels.Manufacturer", "Manufacturer")
                        .WithMany("ElectricalDeviceModels")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Angular.Server.Models.DomainModels.ElectricalSystem", b =>
                {
                    b.HasOne("Angular.Server.Models.DomainModels.BaseUnit", "BaseUnit")
                        .WithMany("ElectricalSystems")
                        .HasForeignKey("BaseUnitId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Angular.Server.Models.DomainModels.ElectricalSystemType", "ElectricalSystemType")
                        .WithMany("ElectricalSystems")
                        .HasForeignKey("ElectricalSystemTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Angular.Server.Models.DomainModels.Person", b =>
                {
                    b.HasOne("Angular.Server.Models.IdentityModels.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Angular.Server.Models.IdentityModels.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Angular.Server.Models.IdentityModels.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Angular.Server.Models.IdentityModels.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
