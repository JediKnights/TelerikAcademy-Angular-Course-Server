namespace Angular.Server.WebAPI.AutoMapper
{
    using global::AutoMapper;
    using Angular.Server.Models.DomainModels;
    using Models;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Person, PersonViewModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName));

            CreateMap<BaseUnit, BaseUnitViewModel>();

            CreateMap<ElectricalDevice, ElectricalDeviceViewModel>()
                .ForMember(dest => dest.ModelName, opt => opt.MapFrom(src => src.ElectricalDeviceModel.ModelName))
                .ForMember(dest => dest.ManufacturerName, opt => opt.MapFrom(src => src.ElectricalDeviceModel.Manufacturer.Name));


            CreateMap<ElectricalDeviceModel, ElectricalDeviceModelViewModel>()
                .ForMember(dest => dest.ManufacturerName, opt => opt.MapFrom(src => src.Manufacturer.Name))
                .ForMember(dest => dest.ElectricalDeviceTypeName, opt => opt.MapFrom(src => src.ElectricalDeviceType.TypeName));
            
        }
    }
}
