using AutoMapper;
using SignatureAPI.Application.DTOs.Company;
using SignatureAPI.Application.DTOs.CompanyComponent;
using SignatureAPI.Application.DTOs.User;
using SignatureAPI.Application.Features.Commands.AppUser.CreateUser;
using SignatureAPI.Application.Features.Commands.Company.CreateCompany;
using SignatureAPI.Application.Features.Commands.Company.UpdateCompany;
using SignatureAPI.Application.Features.Commands.CompanyComponent.CreateCompanyComponent;
using SignatureAPI.Application.Features.Commands.CompanyComponent.UpdateCompanyComponent;
using SignatureAPI.Domain.Entities.Company;
using SignatureAPI.Domain.Entities.CompanyComponent;

namespace SignatureAPI.Application.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyDTO>().ForMember(dest=>dest.Components, opt=>opt.MapFrom(src=>src.CompanyComponents));
            CreateMap<CreateCompanyCommandRequest,Company>().ForMember(dest=>dest.CompanyComponents, opt=>opt.Ignore());
            CreateMap<UpdateCompanyCommandRequest,Company>().ForMember(dest=>dest.CompanyComponents, opt=>opt.Ignore());

            CreateMap<CompanyComponent, CompanyComponentDTO>();
            CreateMap<CreateCompanyComponentCommandRequest, CompanyComponent>()
                .ForMember(x => x.Company, opt => opt.Ignore());

            CreateMap<UpdateCompanyComponentCommandRequest, CompanyComponent>()
                .ForMember(x => x.Company, opt => opt.Ignore());

            CreateMap<CreateUserCommandRequest,CreateUserDTO>().ReverseMap();
        }
    }
}
