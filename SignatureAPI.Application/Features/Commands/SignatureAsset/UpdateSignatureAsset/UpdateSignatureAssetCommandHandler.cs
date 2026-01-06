using AutoMapper;
using MediatR;
using SignatureAPI.Application.Repositories.SignatureAsset;

namespace SignatureAPI.Application.Features.Commands.SignatureAsset.UpdateSignatureAsset
{
    public class UpdateSignatureAssetCommandHandler:IRequestHandler<UpdateSignatureAssetCommandRequest, UpdateSignatureAssetCommandResponse>
    {
        readonly ISignatureAssetWriteRepository _signatureAssetWriteRepository;
        readonly IMapper _mapper;

        public UpdateSignatureAssetCommandHandler(ISignatureAssetWriteRepository signatureAssetWriteRepository, IMapper mapper)
        {
            _signatureAssetWriteRepository = signatureAssetWriteRepository;
            _mapper = mapper;
        }

        public async Task<UpdateSignatureAssetCommandResponse> Handle(UpdateSignatureAssetCommandRequest request, CancellationToken cancellationToken)
        {
            var signatureAsset = _mapper.Map<Domain.Entities.Signature.SignatureAsset>(request);
            _signatureAssetWriteRepository.Update(signatureAsset);
            await _signatureAssetWriteRepository.SaveAsync();
            return new();
        }
    }
}
