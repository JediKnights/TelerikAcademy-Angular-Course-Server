using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

using Angular.Server.Data;
using Angular.Server.Models.DomainModels;
using Angular.Server.Models.IdentityModels;
using Microsoft.Extensions.Logging;
using System.Text;
using System.Threading;

namespace Angular.Server.WebAPI.Seed
{
    public static class DatabaseInitializer
    {
        public static async Task SeedData(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                var userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();

                if (context.AllMigrationsApplied())
                {
                    await SeedDatabase(context, userManager);
                }
            }
        }

        public static async Task SeedDatabase(ApplicationDbContext context, 
            UserManager<ApplicationUser> userManager)
        {
            if (!context.Users.Any())
            {
                var personsWithPasswords = new List<PersonWithPassword>
                {
                    new PersonWithPassword
                    (
                        new ApplicationUser
                        {
                            UserName = "john.doe",
                            Email = "john.doe@sample.com",
                            Address = "45 Long Beach Blvd, Miami"
                        },
                        new Person
                        {
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        "NewPassword123$"
                    ),
                    new PersonWithPassword
                    (
                        new ApplicationUser
                        {
                            UserName = "michael.jordan",
                            Email = "michael.jordan@sample.com",
                            Address = "15 Square Ave, London"
                        },
                        new Person
                        {
                            FirstName = "Michael",
                            LastName = "Jordan"
                        },
                        "FreshPassword123$"
                    )
                };

                foreach (var personWithPassword in personsWithPasswords)
                {
                    var applicationUser = personWithPassword.AppUser;

                    IdentityResult result =
                        await userManager.CreateAsync(applicationUser, personWithPassword.Password);

                    if (result.Succeeded)
                    {
                        var person = personWithPassword.Person;

                        person.ApplicationUserId = applicationUser.Id;

                        context.Persons.Add(person);
                    }
                }

                context.SaveChanges();
            }

            if (!context.Manufacturers.Any())
            {
                var manufacturers = new List<Manufacturer>
                {
                    new Manufacturer() { Name = "Philips" },
                    new Manufacturer() { Name = "Siemens" },
                    new Manufacturer() { Name = "Samsung" },
                    new Manufacturer() { Name = "Asus" },
                    new Manufacturer() { Name = "IBM" },
                    new Manufacturer() { Name = "Whirlpool" },
                    new Manufacturer() { Name = "LG" },
                    new Manufacturer() { Name = "Solar City" },
                    new Manufacturer() { Name = "Tesla" },
                    new Manufacturer() { Name = "Teledyne Energy Systems" },
                };

                context.Manufacturers.AddRange(manufacturers);

                context.SaveChanges();
            }

            if (!context.ElectricalDeviceTypes.Any())
            {
                var electricalDeviceTypes = new List<ElectricalDeviceType>
                {
                    new ElectricalDeviceType() { TypeName = "LED Light" },
                    new ElectricalDeviceType() { TypeName = "Washing Machine" },
                    new ElectricalDeviceType() { TypeName = "Air conditioner" },
                    new ElectricalDeviceType() { TypeName = "Computer" },
                    new ElectricalDeviceType() { TypeName = "Refridgerator" },
                    new ElectricalDeviceType() { TypeName = "Electronic Microscope" },
                    new ElectricalDeviceType() { TypeName = "Water Pump" },
                    new ElectricalDeviceType() { TypeName = "Water Heater" },
                    new ElectricalDeviceType() { TypeName = "Energy Generator" },
                    new ElectricalDeviceType() { TypeName = "Solar panel" },
                    new ElectricalDeviceType() { TypeName = "Radioisotope Thermoelectric Generator" },
                    new ElectricalDeviceType() { TypeName = "Battery Pack" }
                };

                context.ElectricalDeviceTypes.AddRange(electricalDeviceTypes);

                context.SaveChanges();
            }

            if (!context.ElectricalDeviceModels.Any())
            {
                var philips = context.Manufacturers.FirstOrDefault(m => m.Name == "Philips");
                var siemens = context.Manufacturers.FirstOrDefault(m => m.Name == "Siemens");
                var samsung = context.Manufacturers.FirstOrDefault(m => m.Name == "Samsung");
                var whirlpool = context.Manufacturers.FirstOrDefault(m => m.Name == "Whirlpool");
                var lg = context.Manufacturers.FirstOrDefault(m => m.Name == "LG");
                var solarCity = context.Manufacturers.FirstOrDefault(m => m.Name == "Solar City");
                var tesla = context.Manufacturers.FirstOrDefault(m => m.Name == "Tesla");
                var teledyne = context.Manufacturers.FirstOrDefault(m => m.Name == "Teledyne Energy Systems");

                var electricalDeviceModels = new List<ElectricalDeviceModel>
                {
                    new ElectricalDeviceModel()
                    {
                        ModelName = "Philips CH5 Air Conditioner",
                        MeasuringUnit = "Degrees (C)",
                        MinValue = 18.0d,
                        MaxValue = 30.0d,
                        Step = 1.0d,
                        PowerPerStep = 5.6d,
                        PowerAtLowestUnitLevel = 30.0d,
                        ModelIdentifier = "KL54-PLPS",
                        Manufacturer = philips,
                        ElectricalDeviceType = 
                            context.ElectricalDeviceTypes.FirstOrDefault(edt => edt.TypeName == "Air conditioner")
                    },
                    new ElectricalDeviceModel()
                    {
                        ModelName = "Siemens LED Light FC83H",
                        MeasuringUnit = "Lumens",
                        MinValue = 30.0d,
                        MaxValue = 90.0d,
                        Step = 5.0d,
                        PowerPerStep = 0.6,
                        PowerAtLowestUnitLevel = 4.0d,
                        ModelIdentifier = "9DE4-SMNS",
                        Manufacturer = siemens,
                        ElectricalDeviceType = 
                            context.ElectricalDeviceTypes.FirstOrDefault(edt => edt.TypeName == "LED Light")
                    },
                    new ElectricalDeviceModel()
                    {
                        ModelName = "Samsung Fridge DL23M",
                        MeasuringUnit = "Degrees (C)",
                        MinValue = -15.0d,
                        MaxValue = 6.0d,
                        Step = 1.0d,
                        PowerPerStep = 7.0d,
                        PowerAtLowestUnitLevel = 35.0d,
                        ModelIdentifier = "CV7J-SMSG",
                        Manufacturer = samsung,
                        ElectricalDeviceType =
                            context.ElectricalDeviceTypes.FirstOrDefault(edt => edt.TypeName == "Refridgerator")
                    },
                    new ElectricalDeviceModel()
                    {
                        ModelName = "Whirlpool Water Pump DH4F",
                        MeasuringUnit = "LitresPerMin",
                        MinValue = 0.5d,
                        MaxValue = 20.0d,
                        Step = 0.5d,
                        PowerPerStep = 7.0d,
                        PowerAtLowestUnitLevel = 45.0d,
                        ModelIdentifier = "JE3C-WHPL",
                        Manufacturer = whirlpool,
                        ElectricalDeviceType =
                            context.ElectricalDeviceTypes.FirstOrDefault(edt => edt.TypeName == "Water Pump")
                    },
                    new ElectricalDeviceModel()
                    {
                        ModelName = "LG Water Heater KD25",
                        MeasuringUnit = "Degrees (C)",
                        MinValue = 20.0d,
                        MaxValue = 80.0d,
                        Step = 1.0d,
                        PowerPerStep = 0.5d,
                        PowerAtLowestUnitLevel = 22.0d,
                        ModelIdentifier = "90QW-LGLG",
                        Manufacturer = lg,
                        ElectricalDeviceType =
                            context.ElectricalDeviceTypes.FirstOrDefault(edt => edt.TypeName == "Water Heater")
                    },
                    new ElectricalDeviceModel()
                    {
                        ModelName = "Solar City MX45 Panel",
                        MeasuringUnit = "Watts",
                        MinValue = 0.0d,
                        MaxValue = 80.0d,
                        Step = 1.0d,
                        PowerPerStep = 0.5d,
                        PowerAtLowestUnitLevel = 0.0d,
                        ModelIdentifier = "34FD-SLCT",
                        Manufacturer = solarCity,
                        ElectricalDeviceType =
                            context.ElectricalDeviceTypes.FirstOrDefault(edt => edt.TypeName == "Solar panel")
                    },
                    new ElectricalDeviceModel()
                    {
                        ModelName = "Teledyne HJ24 MMRTG",
                        MeasuringUnit = "Degrees (C)",
                        MinValue = 0.0d,
                        MaxValue = 120.0d,
                        Step = 1.0d,
                        PowerPerStep = 0.5d,
                        PowerAtLowestUnitLevel = 0.0d,
                        ModelIdentifier = "3F4F-TLDN",
                        Manufacturer = teledyne,
                        ElectricalDeviceType =
                            context.ElectricalDeviceTypes.FirstOrDefault(edt => edt.TypeName == "Radioisotope Thermoelectric Generator")
                    },
                    new ElectricalDeviceModel()
                    {
                        ModelName = "Tesla 24CF Power Pack",
                        Capacity = 50000,
                        MeasuringUnit = "Degrees (C)",
                        MinValue = 0.0d,
                        MaxValue = 250.0d,
                        Step = 1.0d,
                        PowerPerStep = 0.5d,
                        PowerAtLowestUnitLevel = 0.0d,
                        ModelIdentifier = "90QW-TSLA",
                        Manufacturer = tesla,
                        ElectricalDeviceType =
                            context.ElectricalDeviceTypes.FirstOrDefault(edt => edt.TypeName == "Battery Pack")
                    }
                };

                context.ElectricalDeviceModels.AddRange(electricalDeviceModels);

                context.SaveChanges();

                if (!context.EnergyGenerators.Any())
                {
                    var energyGenerators = new List<EnergyGenerator>();

                    var teledyneRadioisotopeGeneratorModel = 
                        context.ElectricalDeviceModels.FirstOrDefault(edm => edm.ModelName == "Teledyne HJ24 MMRTG");

                    var radioisotopeGenerator = new EnergyGenerator()
                    {
                        SerialNumber = "VC23-DF42-OK49-3F4F-TLDN",
                        ElectricalDeviceModel = teledyneRadioisotopeGeneratorModel
                    };

                    energyGenerators.Add(radioisotopeGenerator);

                    var radioisotopeGeneratorSecond = new EnergyGenerator()
                    {
                        SerialNumber = "LQ21-CA30-SQ1P-3F4F-TLDN",
                        ElectricalDeviceModel = teledyneRadioisotopeGeneratorModel

                    };

                    energyGenerators.Add(radioisotopeGeneratorSecond);

                    string[] setOfStrings = new string[]
                    {
                        "JFC9", "PO92", "CXO9", "AZ39", "PO9W", "QE31", "SXL4", "BA6G"
                    };

                    var solarCityPanelModel =
                        context.ElectricalDeviceModels.FirstOrDefault(edm => edm.ModelName == "Solar City MX45 Panel");

                    int setLength = setOfStrings.Length;

                    Random randomGenerator = new Random();

                    for (int i = 0; i < 20; i++)
                    {
                        StringBuilder sb = new StringBuilder();

                        for (int j = 0; j < 3; j++)
                        {
                            string randomString = setOfStrings[randomGenerator.Next(0, setLength)];
                            sb.AppendFormat("{0}-", randomString);
                        }

                        var energyGenerator = new EnergyGenerator()
                        {
                            SerialNumber = sb.ToString(),
                            ElectricalDeviceModel = solarCityPanelModel
                        };

                        energyGenerators.Add(energyGenerator);
                    }

                    context.EnergyGenerators.AddRange(energyGenerators);

                    context.SaveChanges();
                }

                if (!context.BatteryPacks.Any())
                {
                    var battery = new BatteryPack()
                    {
                        SerialNumber = "D3AP-W24C-QW2X-90QW-TSLA",
                        ElectricalDeviceModel = 
                        context.ElectricalDeviceModels.FirstOrDefault(edm => edm.ModelName == "Tesla 24CF Power Pack")
                    };

                    context.BatteryPacks.Add(battery);

                    context.SaveChanges();
                }
            }

            if (!context.BaseUnits.Any())
            {
                context.BaseUnits.AddRange
                (
                    new BaseUnit { Name = "Living Space" },
                    new BaseUnit { Name = "Green House" }
                );
                context.SaveChanges();
            }

            if (!context.ElectricalSystemTypes.Any())
            {
                var electricalSystemTypes = new List<ElectricalSystemType>
                {
                    new ElectricalSystemType { Name = "Air-Conditining System" },
                    new ElectricalSystemType { Name = "Lighting System" },
                    new ElectricalSystemType { Name = "Fridge System" },
                    new ElectricalSystemType { Name = "Water Pumping System" },
                    new ElectricalSystemType { Name = "Water Heating System" }
                };

                context.ElectricalSystemTypes.AddRange(electricalSystemTypes);

                context.SaveChanges();
            }


            if (!context.ElectricalSystems.Any())
            {
                var livingSpaceBaseUnit = context.BaseUnits.FirstOrDefault(u => u.Name == "Living Space");

                var greenHouseBaseUnit = context.BaseUnits.FirstOrDefault(bu => bu.Name == "Green House");

                var airConditioningSystemType = 
                    context.ElectricalSystemTypes.FirstOrDefault(est => est.Name == "Air-Conditining System");

                var ligthingSystemType =
                    context.ElectricalSystemTypes.FirstOrDefault(est => est.Name == "Lighting System");

                var fridgeSystemType =
                    context.ElectricalSystemTypes.FirstOrDefault(est => est.Name == "Fridge System");

                var waterPumpingSystemType =
                    context.ElectricalSystemTypes.FirstOrDefault(est => est.Name == "Water Pumping System");

                var waterHeatingSystemType =
                    context.ElectricalSystemTypes.FirstOrDefault(est => est.Name == "Water Heating System");

                var airConditioningLivingSpace = new ElectricalSystem()
                {
                    Name = "Air Conditioning System (Living Space)",
                    BaseUnit = livingSpaceBaseUnit,
                    ElectricalSystemType = airConditioningSystemType
                };

                var airConditioningGreenHouse = new ElectricalSystem()
                {
                    Name = "Air Conditioning System (Green House)",
                    BaseUnit = greenHouseBaseUnit,
                    ElectricalSystemType = airConditioningSystemType
                };

                var lightsSystemLivingSpace = new ElectricalSystem()
                {
                    Name = "LED Lights (Living Space)",
                    BaseUnit = livingSpaceBaseUnit,
                    ElectricalSystemType = ligthingSystemType
                };

                var lightsSystemGreenHouse = new ElectricalSystem()
                {
                    Name = "LED Lights (Green House)",
                    BaseUnit = greenHouseBaseUnit,
                    ElectricalSystemType = ligthingSystemType
                };

                var fridgeSystemLivingSpace = new ElectricalSystem()
                {
                    Name = "Fridge System (Living Space)",
                    BaseUnit = livingSpaceBaseUnit,
                    ElectricalSystemType = fridgeSystemType
                };

                var fridgeSystemGreenHouse = new ElectricalSystem()
                {
                    Name = "Fridge System (Green House)",
                    BaseUnit = greenHouseBaseUnit,
                    ElectricalSystemType = fridgeSystemType
                };

                var waterPumpSystemLivingSpace = new ElectricalSystem()
                {
                    Name = "Water Pumping System (Living Space)",
                    BaseUnit = livingSpaceBaseUnit,
                    ElectricalSystemType = waterPumpingSystemType
                };

                var waterPumpSystemGreenHouse = new ElectricalSystem()
                {
                    Name = "Water Pumping System (Green House)",
                    BaseUnit = greenHouseBaseUnit,
                    ElectricalSystemType = waterPumpingSystemType
                };

                var waterHeatingSystemLivingSpace = new ElectricalSystem()
                {
                    Name = "Water Heating System (Living Space)",
                    BaseUnit = livingSpaceBaseUnit,
                    ElectricalSystemType = waterHeatingSystemType
                };

                var waterHeatingSystemGreenHouse = new ElectricalSystem()
                {
                    Name = "Water Heating System (Green House)",
                    BaseUnit = greenHouseBaseUnit,
                    ElectricalSystemType = waterHeatingSystemType
                };

                var electricalSystems = new List<ElectricalSystem>
                {
                    airConditioningLivingSpace,
                    airConditioningGreenHouse,
                    lightsSystemLivingSpace,
                    lightsSystemGreenHouse,
                    fridgeSystemLivingSpace,
                    fridgeSystemGreenHouse,
                    waterPumpSystemLivingSpace,
                    waterPumpSystemGreenHouse,
                    waterHeatingSystemLivingSpace,
                    waterHeatingSystemGreenHouse
                };

                context.ElectricalSystems.AddRange(electricalSystems);

                context.SaveChanges();
            }

            if (!context.ElectricalDevices.Any())
            {
                var ledLightsLivingSpaceSystem =
                       context.ElectricalSystems.FirstOrDefault(es => es.Name == "LED Lights (Living Space)");

                var ledLightsGreenHouseSystem =
                       context.ElectricalSystems.FirstOrDefault(es => es.Name == "LED Lights (Living Space)");

                var philipsCH5AirConditioner =
                       context.ElectricalDeviceModels.FirstOrDefault(es => es.ModelName == "Philips CH5 Air Conditioner");

                var siemensLEDLightFC83H = context.ElectricalDeviceModels.FirstOrDefault(es => es.ModelName == "Siemens LED Light FC83H");

                var samsungFridgeDL23M = context.ElectricalDeviceModels.FirstOrDefault(es => es.ModelName == "Samsung Fridge DL23M");

                var whirlpoolWaterPumpDH4F = context.ElectricalDeviceModels.FirstOrDefault(es => es.ModelName == "Whirlpool Water Pump DH4F");

                var lgWaterHeaterKD25 = context.ElectricalDeviceModels.FirstOrDefault(es => es.ModelName == "LG Water Heater KD25");

                var electricalDevices = new List<ElectricalDevice>
                {
                    new ElectricalDevice()
                    {
                        SerialNumber = "4HDE-BHRU-98CH-KL54-PLPS",
                        ElectricalDeviceModel = philipsCH5AirConditioner,
                        ElectricalSystem = 
                            context.ElectricalSystems.FirstOrDefault(es => es.Name == "Air Conditioning System (Living Space)"),
                        MeasuringUnitCurrentLevel = 21.0d
                    },
                    new ElectricalDevice()
                    {
                        SerialNumber = "BNMV-RT65-AS9K-KL54-PLPS",
                        ElectricalDeviceModel = philipsCH5AirConditioner,
                        ElectricalSystem =
                            context.ElectricalSystems.FirstOrDefault(es => es.Name == "Air Conditioning System (Green House)"),
                        MeasuringUnitCurrentLevel = 21.0d
                    },
                    new ElectricalDevice()
                    {
                        SerialNumber = "8XCD-GHJD-82WD-9DE4-SMNS",
                        ElectricalDeviceModel = siemensLEDLightFC83H,
                        ElectricalSystem = ledLightsLivingSpaceSystem,
                        MeasuringUnitCurrentLevel = 30.0d
                    },
                    new ElectricalDevice()
                    {
                        SerialNumber = "KERL-PKS1-DF9A-9DE4-SMNS",
                        ElectricalDeviceModel = siemensLEDLightFC83H,
                        ElectricalSystem = ledLightsLivingSpaceSystem,
                        MeasuringUnitCurrentLevel = 30.0d
                    },
                    new ElectricalDevice()
                    {
                        SerialNumber = "BCRE-MGHW-KSD3-9DE4-SMNS",
                        ElectricalDeviceModel = siemensLEDLightFC83H,
                        ElectricalSystem = ledLightsGreenHouseSystem,
                        MeasuringUnitCurrentLevel = 45.0d
                    },
                    new ElectricalDevice()
                    {
                        SerialNumber = "PA8G-LM2A-DF9A-9DE4-SMNS",
                        ElectricalDeviceModel = siemensLEDLightFC83H,
                        ElectricalSystem = ledLightsGreenHouseSystem,
                        MeasuringUnitCurrentLevel = 45.0d
                    },
                    new ElectricalDevice()
                    {
                        SerialNumber = "PKLC-WERP-CVBH-CV7J-SMSG",
                        ElectricalDeviceModel = samsungFridgeDL23M,
                        ElectricalSystem =
                            context.ElectricalSystems.FirstOrDefault(es => es.Name == "Fridge System (Living Space)"),
                        MeasuringUnitCurrentLevel = 4.0d
                    },
                    new ElectricalDevice()
                    {
                        SerialNumber = "MVC8-KDKD-CD9K-CV7J-SMSG",
                        ElectricalDeviceModel = samsungFridgeDL23M,
                        ElectricalSystem =
                            context.ElectricalSystems.FirstOrDefault(es => es.Name == "Fridge System (Green House)"),
                        MeasuringUnitCurrentLevel = 4.0d
                    },
                    new ElectricalDevice()
                    {
                        SerialNumber = "FH3S-DE4C-CF5D-JE3C-WHPL",
                        ElectricalDeviceModel = whirlpoolWaterPumpDH4F,
                        ElectricalSystem =
                            context.ElectricalSystems.FirstOrDefault(es => es.Name == "Water Pumping System (Living Space)"),
                        MeasuringUnitCurrentLevel = 14.0d
                    },
                    new ElectricalDevice()
                    {
                        SerialNumber = "MVC8-KDKD-CD9K-JE3C-WHPL",
                        ElectricalDeviceModel = whirlpoolWaterPumpDH4F,
                        ElectricalSystem =
                            context.ElectricalSystems.FirstOrDefault(es => es.Name == "Water Pumping System (Green House)"),
                        MeasuringUnitCurrentLevel = 0.5d
                    },
                    new ElectricalDevice()
                    {
                        SerialNumber = "8XCD-GHJD-82WD-90QW-LGLG",
                        ElectricalDeviceModel = lgWaterHeaterKD25,
                        ElectricalSystem =
                            context.ElectricalSystems.FirstOrDefault(es => es.Name == "Water Heating System (Living Space)"),
                        MeasuringUnitCurrentLevel = 70.0d
                    },
                    new ElectricalDevice()
                    {
                        SerialNumber = "KL2W-AS2E-WE3C-90QW-LGLG",
                        ElectricalDeviceModel = lgWaterHeaterKD25,
                        ElectricalSystem =
                            context.ElectricalSystems.FirstOrDefault(es => es.Name == "Water Heating System (Green House)"),
                        MeasuringUnitCurrentLevel = 20.0d
                    }
                };

                context.ElectricalDevices.AddRange(electricalDevices);

                context.SaveChanges();
            }
        }
    }

    public class PersonWithPassword
    {
        public PersonWithPassword(ApplicationUser appUser, Person person, string password)
        {
            this.AppUser = appUser;
            this.Password = password;
            this.Person = person;
        }

        public ApplicationUser AppUser { get; set; }


        public Person Person { get; set; }

        public string Password { get; set; }
    }
}
