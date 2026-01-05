using AutoMapper;
using SignatureAPI.Application.DTOs.Company;
using SignatureAPI.Application.DTOs.Signature;
using SignatureAPI.Application.DTOs.SignatureAsset;
using SignatureAPI.Application.DTOs.SignatureLink;
using SignatureAPI.Domain.Entities.Company;
using SignatureAPI.Domain.Entities.Signature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, ResultCompanyDTO>().ReverseMap();
            CreateMap<Signature, ResultSignatureDTO>().ReverseMap();
            CreateMap<SignatureAsset, ResultSignatureAssetDTO>().ReverseMap();
            CreateMap<SignatureLink, ResultSignatureLinkDTO>().ReverseMap();
        }
    }
}
