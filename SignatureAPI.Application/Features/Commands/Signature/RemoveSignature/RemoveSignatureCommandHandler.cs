using MediatR;
using SignatureAPI.Application.Repositories.Signature;

namespace SignatureAPI.Application.Features.Commands.Signature.RemoveSignature
{
    public class RemoveSignatureCommandHandler:IRequestHandler<RemoveSignatureCommandRequest, RemoveSignatureCommandResponse>
    {
        readonly ISignatureWriteRepository _signatureWriteRepository;

        public RemoveSignatureCommandHandler(ISignatureWriteRepository signatureWriteRepository)
        {
            _signatureWriteRepository = signatureWriteRepository;
        }

        public async Task<RemoveSignatureCommandResponse> Handle(RemoveSignatureCommandRequest request, CancellationToken cancellationToken)
        {
           await _signatureWriteRepository.RemoveAsync(request.Id);
            await _signatureWriteRepository.SaveAsync();
            return new();
        }
    }
}
