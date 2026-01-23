using AutoMapper;
using SignatureAPI.Application.DTOs.Company;
using SignatureAPI.Application.DTOs.User;
using SignatureAPI.Application.Features.Commands.AppUser.CreateUser;
using SignatureAPI.Application.Features.Commands.Company.CreateCompany;
using SignatureAPI.Application.Features.Commands.Company.UpdateCompany;
using SignatureAPI.Domain.Entities.Company;
using SignatureAPI.Domain.Entities.CompanyComponent;

namespace SignatureAPI.Application.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyDTO>();
            CreateMap<Company,CreateCompanyCommandRequest>().ReverseMap();
            CreateMap<Company,UpdateCompanyCommandRequest>().ReverseMap();

            CreateMap<CompanyComponent,CompanyComponentDTO>().ReverseMap();
            CreateMap<CompanyComponent, CreateCompanyCommandRequest>().ReverseMap();
            CreateMap<CompanyComponent, UpdateCompanyCommandRequest>().ReverseMap();

            CreateMap<CreateUserCommandRequest,CreateUserDTO>().ReverseMap();
        }
    }
}
