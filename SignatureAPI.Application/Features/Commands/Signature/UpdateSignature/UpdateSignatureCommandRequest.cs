using MediatR;
using SignatureAPI.Application.DTOs.Signature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Features.Commands.Signature.UpdateSignature
{
    public class UpdateSignatureCommandRequest:IRequest<UpdateSignatureCommandResponse>
    {
        public UpdateSignatureCommandRequest()
        {
            SignatureAssets = new List<SignatureAssetDTO>();
            SignatureLinks = new List<SignatureLinkDTO>();
        }
        public string Id { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Address { get; set; }
        public string? KdvText { get; set; }
        public string? InformationText { get; set; }
        public string? EnvironmentText { get; set; }
        public string CompanyId { get; set; }
        public List<SignatureAssetDTO> SignatureAssets { get; set; }
        public List<SignatureLinkDTO> SignatureLinks { get; set; }
    }
}
