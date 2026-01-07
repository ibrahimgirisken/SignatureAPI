using MediatR;

namespace SignatureAPI.Application.Features.Commands.SignatureLink.RemoveSignatureLink
{
    public class RemoveSignatureLinkCommandRequest:IRequest<RemoveSignatureLinkCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
