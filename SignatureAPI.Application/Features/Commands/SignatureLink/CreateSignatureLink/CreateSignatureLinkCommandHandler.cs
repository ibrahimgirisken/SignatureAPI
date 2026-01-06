using AutoMapper;
using MediatR;
using SignatureAPI.Application.Repositories.SignatureAsset;


namespace SignatureAPI.Application.Features.Commands.SignatureLink.CreateSignatureLink
{
    public class CreateSignatureLinkCommandHandler:IRequestHandler<CreateSignatureLinkCommandRequest, CreateSignatureLinkCommandResponse>
    {
        readonly ISignatureAssetWriteRepository _signatureAssetWriteRepository;
        readonly IMapper _mapper;

        public CreateSignatureLinkCommandHandler(ISignatureAssetWriteRepository signatureAssetWriteRepository, IMapper mapper)
        {
            _signatureAssetWriteRepository = signatureAssetWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateSignatureLinkCommandResponse> Handle(CreateSignatureLinkCommandRequest request, CancellationToken cancellationToken)
        {
            var signatureAsset = _mapper.Map<Domain.Entities.Signature.SignatureAsset>(request);
            await _signatureAssetWriteRepository.AddAsync(signatureAsset);
            await _signatureAssetWriteRepository.SaveAsync();
            return new();
        }
    }
}
