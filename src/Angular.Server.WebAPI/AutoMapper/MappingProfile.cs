namespace Angular.Server.WebAPI.AutoMapper
{
    using global::AutoMapper;
    using Angular.Server.Models.DomainModels;
    using Models;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Person, PersonModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName));
        }
    }
}
