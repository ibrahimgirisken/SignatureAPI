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

        public async Task<RemoveSignatureLinkCommandResponse> Handle(RemoveSignatureLinkCommandRequest request, CancellationToken cancellationToken)
        {
            await _signatureLinkWriteRepository.RemoveAsync(request.Id);
            await _signatureLinkWriteRepository.SaveAsync();
            return new();
        }
    }
}
