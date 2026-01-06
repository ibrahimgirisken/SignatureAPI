using AutoMapper;
using MediatR;
using SignatureAPI.Application.Repositories.SignatureLink;

namespace SignatureAPI.Application.Features.Commands.SignatureLink.UpdateSignatureLink
{
    public class UpdateSignatureLinkCommandHandler:IRequestHandler<UpdateSignatureLinkCommandRequest, UpdateSignatureLinkCommandResponse>
    {
        readonly ISignatureLinkWriteRepository _signatureLinkWriteRepository;
        readonly IMapper _mapper;

        public UpdateSignatureLinkCommandHandler(ISignatureLinkWriteRepository signatureLinkWriteRepository, IMapper mapper)
        {
            _signatureLinkWriteRepository = signatureLinkWriteRepository;
            _mapper = mapper;
        }

        public async Task<UpdateSignatureLinkCommandResponse> Handle(UpdateSignatureLinkCommandRequest request, CancellationToken cancellationToken)
        {
            var signatureLink = _mapper.Map<Domain.Entities.Signature.SignatureLink>(request);
           _signatureLinkWriteRepository.Update(signatureLink);
           await _signatureLinkWriteRepository.SaveAsync();
            return new();
        }
    }

}
