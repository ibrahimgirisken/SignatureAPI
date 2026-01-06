using AutoMapper;
using MediatR;
using SignatureAPI.Application.Repositories.SignatureAsset;

namespace SignatureAPI.Application.Features.Commands.SignatureAsset.CreateSignatureAsset
{
    public class CreateSignatureAssetCommandHandler : IRequestHandler<CreateSignatureAssetCommandRequest, CreateSignatureAssetCommandResponse>
    {
        readonly ISignatureAssetWriteRepository _signatureAssetWriteRepository;
        readonly IMapper _mapper;

        public CreateSignatureAssetCommandHandler(ISignatureAssetWriteRepository signatureAssetWriteRepository, IMapper mapper)
        {
            _signatureAssetWriteRepository = signatureAssetWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateSignatureAssetCommandResponse> Handle(CreateSignatureAssetCommandRequest request, CancellationToken cancellationToken)
        {
            var signatureAsset = _mapper.Map<Domain.Entities.Signature.SignatureAsset>(request);
            await _signatureAssetWriteRepository.AddAsync(signatureAsset);
            await _signatureAssetWriteRepository.SaveAsync();
            return new();
        }
    }
}
