using AutoMapper;
using MediatR;
using SignatureAPI.Application.Repositories.SignatureAsset;

namespace SignatureAPI.Application.Features.Commands.SignatureAsset.RemoveSignatureAsset
{
    public class RemoveSignatureAssetCommandHandler:IRequestHandler<RemoveSignatureAssetCommandRequest, RemoveSignatureAssetCommandResponse>
    {
        readonly ISignatureAssetWriteRepository _signatureAssetWriteRepository;

        public RemoveSignatureAssetCommandHandler(ISignatureAssetWriteRepository signatureAssetWriteRepository)
        {
            _signatureAssetWriteRepository = signatureAssetWriteRepository;
        }

        public async Task<RemoveSignatureAssetCommandResponse> Handle(RemoveSignatureAssetCommandRequest request, CancellationToken cancellationToken)
        {
           await _signatureAssetWriteRepository.RemoveAsync(request.Id);
           await _signatureAssetWriteRepository.SaveAsync();
            return new();
        }
    }
}
