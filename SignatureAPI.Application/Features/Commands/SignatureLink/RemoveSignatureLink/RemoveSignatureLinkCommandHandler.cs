using MediatR;
using SignatureAPI.Application.Repositories.SignatureLink;

namespace SignatureAPI.Application.Features.Commands.SignatureLink.RemoveSignatureLink
{
    public class RemoveSignatureLinkCommandHandler:IRequestHandler<RemoveSignatureLinkCommandRequest, RemoveSignatureLinkCommandResponse>
    {
        readonly ISignatureLinkWriteRepository _signatureLinkWriteRepository;

        public RemoveSignatureLinkCommandHandler(ISignatureLinkWriteRepository signatureLinkWriteRepository)
        {
            _signatureLinkWriteRepository = signatureLinkWriteRepository;
        }

        public Task<RemoveSignatureLinkCommandResponse> Handle(RemoveSignatureLinkCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
