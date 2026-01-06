using MediatR;

namespace SignatureAPI.Application.Features.Commands.SignatureAsset.RemoveSignatureAsset
{
    public class RemoveSignatureAssetCommandRequest:IRequest<RemoveSignatureAssetCommandResponse>
    {
        public string Id { get; set; }
    }
}
