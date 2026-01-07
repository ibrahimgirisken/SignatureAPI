using AutoMapper;
using MediatR;
using SignatureAPI.Application.Repositories.SignatureAsset;

namespace SignatureAPI.Application.Features.Commands.Signature.UpdateSignature
{
    public class UpdateSignatureCommandHandler:IRequestHandler<UpdateSignatureCommandRequest, UpdateSignatureCommandResponse>
    {
        readonly ISignatureAssetWriteRepository _signatureAssetWriteRepository;
        readonly ISignatureAssetReadRepository _signatureAssetReadRepository;
        readonly IMapper _mapper;

        public UpdateSignatureCommandHandler(ISignatureAssetWriteRepository signatureAssetWriteRepository, IMapper mapper, ISignatureAssetReadRepository signatureAssetReadRepository = null)
        {
            _signatureAssetWriteRepository = signatureAssetWriteRepository;
            _signatureAssetReadRepository = signatureAssetReadRepository;
            _mapper = mapper;
        }

        public async Task<UpdateSignatureCommandResponse> Handle(UpdateSignatureCommandRequest request, CancellationToken cancellationToken)
        {
            var signatureAsset = await _signatureAssetReadRepository.GetByIdAsync(request.Id);
            _mapper.Map(request, signatureAsset);
            await _signatureAssetWriteRepository.SaveAsync();
            return new();
        }
    }
}
