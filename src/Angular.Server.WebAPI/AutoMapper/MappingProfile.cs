using AutoMapper;

using Angular.Server.Models.DomainModels;
using Angular.Server.WebAPI.Models.BaseUnit;
using Angular.Server.WebAPI.Models.BatteryPack;
using Angular.Server.WebAPI.Models.ElectricalDevice;
using Angular.Server.WebAPI.Models.ElectricalDeviceModel;
using Angular.Server.WebAPI.Models.ElectricalDeviceType;
using Angular.Server.WebAPI.Models.ElectricalSystem;
using Angular.Server.WebAPI.Models.ElectricalSystemType;
using Angular.Server.WebAPI.Models.EnergyGenerator;
using Angular.Server.WebAPI.Models.Person;

namespace Angular.Server.WebAPI.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMaps();
        }

        protected void CreateMaps()
        {
            //Map Domain models to List View (GET) models:
            CreateMap<Person, PersonListModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName));

            CreateMap<BaseUnit, BaseUnitListModel>();

            CreateMap<ElectricalDevice, ElectricalDeviceListModel>()
                .ForMember(dest => dest.ModelName, opt => opt.MapFrom(src => src.ElectricalDeviceModel.ModelName))
                .ForMember(dest => dest.ManufacturerName, opt => opt.MapFrom(src => src.ElectricalDeviceModel.Manufacturer.Name));

            CreateMap<ElectricalDeviceModel, ElectricalDeviceModelListModel>()
                .ForMember(dest => dest.ManufacturerName, opt => opt.MapFrom(src => src.Manufacturer.Name))
                .ForMember(dest => dest.ElectricalDeviceTypeName, opt => opt.MapFrom(src => src.ElectricalDeviceType.TypeName));

            CreateMap<ElectricalDeviceType, ElectricalDeviceTypeListModel>();

            CreateMap<ElectricalSystem, ElectricalSystemListModel>()
                .ForMember(dest => dest.ElectricalSystemTypeName, opt => opt.MapFrom(src => src.ElectricalSystemType.Name))
                .ForMember(dest => dest.BaseUnitName, opt => opt.MapFrom(src => src.BaseUnit.Name));

            CreateMap<ElectricalSystemType, ElectricalSystemTypeListModel>();

            CreateMap<BatteryPack, BatteryPackListModel>();

            CreateMap<EnergyGenerator, EnergyGeneratorListModel>()
                .ForMember(dest => dest.ElectricalDeviceModelName, opt => opt.MapFrom(src => src.ElectricalDeviceModel.ModelName));

            //Map Domain models to Details (GET) models:
            CreateMap<Person, PersonDetailsModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName));

            CreateMap<BaseUnit, BaseUnitDetailsModel>();

            CreateMap<ElectricalDevice, ElectricalDeviceDetailsModel>()
                .ForMember(dest => dest.ModelName, opt => opt.MapFrom(src => src.ElectricalDeviceModel.ModelName))
                .ForMember(dest => dest.ManufacturerName, opt => opt.MapFrom(src => src.ElectricalDeviceModel.Manufacturer.Name));

            CreateMap<ElectricalDeviceModel, ElectricalDeviceModelDetailsModel>()
                .ForMember(dest => dest.ManufacturerName, opt => opt.MapFrom(src => src.Manufacturer.Name))
                .ForMember(dest => dest.ElectricalDeviceTypeName, opt => opt.MapFrom(src => src.ElectricalDeviceType.TypeName));

            CreateMap<ElectricalDeviceType, ElectricalDeviceTypeDetailsModel>();

            CreateMap<ElectricalSystem, ElectricalSystemDetailsModel>()
                .ForMember(dest => dest.ElectricalSystemTypeName, opt => opt.MapFrom(src => src.ElectricalSystemType.Name))
                .ForMember(dest => dest.BaseUnitName, opt => opt.MapFrom(src => src.BaseUnit.Name));

            CreateMap<ElectricalSystemType, ElectricalSystemTypeDetailsModel>();

            CreateMap<BatteryPack, BatteryPackDetailsModel>();

            CreateMap<EnergyGenerator, EnergyGeneratorDetailsModel>()
                .ForMember(dest => dest.ElectricalDeviceModelName, opt => opt.MapFrom(src => src.ElectricalDeviceModel.ModelName));

            //Map Create (POST) models to Domain models:
            CreateMap<PersonCreateModel, Person>();

            CreateMap<BaseUnitCreateModel, BaseUnit>();

            CreateMap<ElectricalDeviceCreateModel, ElectricalDevice>();

            CreateMap<ElectricalDeviceModelCreateModel, ElectricalDeviceModel>();

            CreateMap<ElectricalDeviceTypeCreateModel, ElectricalDeviceType>();

            CreateMap<ElectricalSystemCreateModel, ElectricalSystem>();

            CreateMap<ElectricalSystemTypeCreateModel, ElectricalSystemType>();

            CreateMap<BatteryPackCreateModel, BatteryPack>();

            CreateMap<EnergyGeneratorCreateModel, EnergyGenerator>();


            //Map Edit (PUT) models to Domain models:
            CreateMap<PersonEditModel, Person>();

            CreateMap<BaseUnitEditModel, BaseUnit>();

            CreateMap<ElectricalDeviceEditModel, ElectricalDevice>();

            CreateMap<ElectricalDeviceModelEditModel, ElectricalDeviceModel>();

            CreateMap<ElectricalDeviceTypeEditModel, ElectricalDeviceType>();

            CreateMap<ElectricalSystemEditModel, ElectricalSystem>();

            CreateMap<ElectricalSystemTypeEditModel, ElectricalSystemType>();

            CreateMap<BatteryPackEditModel, BatteryPack>();

            CreateMap<EnergyGeneratorEditModel, EnergyGenerator>();
        }
    }
}
