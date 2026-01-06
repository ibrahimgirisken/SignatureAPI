using MediatR;
using SignatureAPI.Application.DTOs.Signature;

namespace SignatureAPI.Application.Features.Commands.Signature.CreateSignature
{
    public class CreateSignatureCommandRequest:IRequest<CreateSignatureCommandResponse>
    {
        public CreateSignatureCommandRequest()
        {
            SignatureAssets = new List<SignatureAssetDTO>();
            SignatureLinks = new List<SignatureLinkDTO>();
        }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Address { get; set; }
        public string? KdvText { get; set; }
        public string? InformationText { get; set; }
        public string? EnvironmentText { get; set; }
        public string? CompanyId { get; set; }
        public List<SignatureAssetDTO> SignatureAssets { get; set; }
        public List<SignatureLinkDTO> SignatureLinks { get; set; }
    }
}
