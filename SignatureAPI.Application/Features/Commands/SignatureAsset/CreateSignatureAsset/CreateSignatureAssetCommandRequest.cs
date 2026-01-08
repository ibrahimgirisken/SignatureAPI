using MediatR;

namespace SignatureAPI.Application.Features.Commands.SignatureAsset.CreateSignatureAsset
{
    public class CreateSignatureAssetCommandRequest:IRequest<CreateSignatureAssetCommandResponse>
    {
        public int? SignatureType { get; set; }
        public string? Url { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }=true;
        public Guid? SignatureId { get; set; }
    }
}
