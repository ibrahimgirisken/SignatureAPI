using AutoMapper;
using MediatR;
using SignatureAPI.Application.Repositories.Signature;

namespace SignatureAPI.Application.Features.Commands.Signature.CreateSignature
{
    public class CreateSignatureCommandHandler : IRequestHandler<CreateSignatureCommandRequest, CreateSignatureCommandResponse>
    {
        readonly ISignatureWriteRepository _signatureWriteRepository;
        readonly IMapper _mapper;

        public CreateSignatureCommandHandler(ISignatureWriteRepository signatureWriteRepository, IMapper mapper)
        {
            _signatureWriteRepository = signatureWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateSignatureCommandResponse> Handle(CreateSignatureCommandRequest request, CancellationToken cancellationToken)
        {
            var signature=_mapper.Map<Domain.Entities.Signature.Signature>(request);
            await _signatureWriteRepository.AddAsync(signature);
            await _signatureWriteRepository.SaveAsync();
            return new();
        }
    }
}
