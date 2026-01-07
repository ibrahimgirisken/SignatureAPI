using MediatR;

namespace SignatureAPI.Application.Features.Commands.Signature.RemoveSignature
{
    public class RemoveSignatureCommandRequest:IRequest<RemoveSignatureCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
