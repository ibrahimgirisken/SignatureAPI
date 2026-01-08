using AutoMapper;
using MediatR;
using SignatureAPI.Application.Repositories.Signature;
using SignatureAPI.Application.Repositories.SignatureAsset;

namespace SignatureAPI.Application.Features.Commands.Signature.UpdateSignature
{
    public class UpdateSignatureCommandHandler:IRequestHandler<UpdateSignatureCommandRequest, UpdateSignatureCommandResponse>
    {
        readonly ISignatureWriteRepository _signatureWriteRepository;
        readonly ISignatureReadRepository _signatureReadRepository;
        readonly IMapper _mapper;

        public UpdateSignatureCommandHandler(ISignatureWriteRepository signatureWriteRepository, ISignatureReadRepository signatureReadRepository, IMapper mapper)
        {
            _signatureWriteRepository = signatureWriteRepository;
            _signatureReadRepository = signatureReadRepository;
            _mapper = mapper;
        }

        public async Task<UpdateSignatureCommandResponse> Handle(UpdateSignatureCommandRequest request, CancellationToken cancellationToken)
        {
            var signatureAsset = await _signatureReadRepository.GetByIdAsync(request.Id);
            _mapper.Map(request, signatureAsset);
            await _signatureWriteRepository.SaveAsync();
            return new();
        }
    }
}
