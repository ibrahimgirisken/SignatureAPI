using AutoMapper;
using MediatR;
using SignatureAPI.Application.Repositories.SignatureAsset;

namespace SignatureAPI.Application.Features.Commands.SignatureAsset.RemoveSignatureAsset
{
    public class RemoveSignatureAssetCommandHandler:IRequestHandler<RemoveSignatureAssetCommandRequest, RemoveSignatureAssetCommandResponse>
    {
        readonly ISignatureAssetWriteRepository _signatureAssetWriteRepository;
        readonly IMapper _mapper;

        public RemoveSignatureAssetCommandHandler(ISignatureAssetWriteRepository signatureAssetWriteRepository, IMapper mapper)
        {
            _signatureAssetWriteRepository = signatureAssetWriteRepository;
            _mapper = mapper;
        }

        public Task<RemoveSignatureAssetCommandResponse> Handle(RemoveSignatureAssetCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
