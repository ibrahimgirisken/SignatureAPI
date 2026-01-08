using AutoMapper;
using MediatR;
using SignatureAPI.Application.Repositories.SignatureAsset;
using SignatureAPI.Application.Repositories.SignatureLink;


namespace SignatureAPI.Application.Features.Commands.SignatureLink.CreateSignatureLink
{
    public class CreateSignatureLinkCommandHandler:IRequestHandler<CreateSignatureLinkCommandRequest, CreateSignatureLinkCommandResponse>
    {
        readonly ISignatureLinkWriteRepository _signatureLinkWriteRepository;
        readonly IMapper _mapper;

        public CreateSignatureLinkCommandHandler(ISignatureLinkWriteRepository signatureLinkWriteRepository, IMapper mapper)
        {
            _signatureLinkWriteRepository = signatureLinkWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateSignatureLinkCommandResponse> Handle(CreateSignatureLinkCommandRequest request, CancellationToken cancellationToken)
        {
            var signatureLink = _mapper.Map<Domain.Entities.Signature.SignatureLink>(request);
            await _signatureLinkWriteRepository.AddAsync(signatureLink);
            await _signatureLinkWriteRepository.SaveAsync();
            return new();
        }
    }
}
