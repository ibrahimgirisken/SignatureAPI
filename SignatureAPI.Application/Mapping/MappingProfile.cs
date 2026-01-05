using AutoMapper;
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
            CreateMap<Domain.Entities.Company.Company, DTOs.Company.ResultCompanyDTO>().ReverseMap();
            CreateMap<Domain.Entities.Signature.Signature, DTOs.Signature.ResultSignatureDTO>().ReverseMap();
            CreateMap<Domain.Entities.Signature.SignatureAsset, DTOs.SignatureAsset.ResultSignatureAssetDTO>().ReverseMap();
            CreateMap<Domain.Entities.Signature.SignatureLink, DTOs.SignatureLink.ResultSignatureLinkDTO>().ReverseMap();
        }
    }
}
