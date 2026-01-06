using MediatR;

namespace SignatureAPI.Application.Features.Commands.SignatureAsset.CreateSignatureAsset
{
    public class CreateSignatureAssetCommandRequest:IRequest<CreateSignatureAssetCommandResponse>
    {
        public string? SignatureType { get; set; }
        public string? Url { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }=true;
        public string? SignatureId { get; set; }
    }
}
