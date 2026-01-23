using AutoMapper;
using SignatureAPI.Application.DTOs.Company;
using SignatureAPI.Application.DTOs.CompanyComponent;
using SignatureAPI.Application.DTOs.User;
using SignatureAPI.Application.Features.Commands.AppUser.CreateUser;
using SignatureAPI.Domain.Entities.Company;
using SignatureAPI.Domain.Entities.CompanyComponent;

namespace SignatureAPI.Application.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyDTO>().ForMember(dest=>dest.Components, opt=>opt.MapFrom(src=>src.CompanyComponents));
            CreateMap<CreateCompanyDTO,Company>().ForMember(dest=>dest.CompanyComponents, opt=>opt.Ignore());
            CreateMap<UpdateCompanyDTO,Company>().ForMember(dest=>dest.CompanyComponents, opt=>opt.Ignore());

            CreateMap<CompanyComponent, CompanyComponentDTO>();
            CreateMap<CreateCompanyComponentDTO, CompanyComponent>()
                .ForMember(x => x.Company, opt => opt.Ignore())
                .ForMember(x => x.CompanyId, opt => opt.Ignore());

            CreateMap<UpdateCompanyComponentDTO, CompanyComponent>()
                .ForMember(x => x.Company, opt => opt.Ignore())
                .ForMember(x => x.CompanyId, opt => opt.Ignore());

            CreateMap<CreateUserCommandRequest,CreateUserDTO>().ReverseMap();
        }
    }
}
