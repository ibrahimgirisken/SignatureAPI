using AutoMapper;
using SignatureAPI.Application.DTOs.Company;
using SignatureAPI.Application.DTOs.Signature;
using SignatureAPI.Application.Features.Commands.Company.CreateCompany;
using SignatureAPI.Application.Features.Commands.Company.UpdateCompany;
using SignatureAPI.Application.Features.Commands.Signature.CreateSignature;
using SignatureAPI.Application.Features.Commands.Signature.UpdateSignature;
using SignatureAPI.Application.Features.Commands.SignatureAsset.CreateSignatureAsset;
using SignatureAPI.Application.Features.Commands.SignatureAsset.UpdateSignatureAsset;
using SignatureAPI.Application.Features.Commands.SignatureLink.CreateSignatureLink;
using SignatureAPI.Application.Features.Commands.SignatureLink.UpdateSignatureLink;
using SignatureAPI.Domain.Entities.Company;
using SignatureAPI.Domain.Entities.Signature;

namespace SignatureAPI.Application.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, ResultCompanyDTO>();
            CreateMap<Company,CreateCompanyCommandRequest>().ReverseMap();
            CreateMap<Company,UpdateCompanyCommandRequest>().ReverseMap();

            CreateMap<Signature,SignatureDTO>().ReverseMap();
            CreateMap<Signature,CreateSignatureCommandRequest>().ReverseMap();
            CreateMap<Signature,UpdateSignatureCommandRequest>().ReverseMap();

            CreateMap<SignatureAsset,SignatureAssetDTO>().ReverseMap();
            CreateMap<SignatureAsset,CreateSignatureAssetCommandRequest>().ReverseMap();
            CreateMap<SignatureAsset,UpdateSignatureAssetCommandRequest>().ReverseMap();

            CreateMap<SignatureLink, SignatureLinkDTO>().ReverseMap();
            CreateMap<SignatureLink, CreateSignatureLinkCommandRequest>().ReverseMap();
            CreateMap<SignatureLink, UpdateSignatureLinkCommandRequest>().ReverseMap();
        }
    }
}
