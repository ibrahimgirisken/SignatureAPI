using MediatR;

namespace SignatureAPI.Application.Features.Commands.SignatureAsset.RemoveSignatureAsset
{
    public class RemoveSignatureAssetCommandRequest:IRequest<RemoveSignatureAssetCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
