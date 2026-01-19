using AutoMapper;
using MediatR;
using SignatureAPI.Application.DTOs.Signature;
using SignatureAPI.Application.Repositories.Signature;

namespace SignatureAPI.Application.Features.Queries.Signature.GetByIdSignature
{
    public class GetByIdSignatureQueryHandler : IRequestHandler<GetByIdSignatureQueryRequest, GetByIdSignatureQueryResponse>
    {
        readonly ISignatureReadRepository _signatureReadRepository;
        readonly IMapper _mapper;

        public GetByIdSignatureQueryHandler(ISignatureReadRepository signatureReadRepository, IMapper mapper)
        {
            _signatureReadRepository = signatureReadRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdSignatureQueryResponse> Handle(GetByIdSignatureQueryRequest request, CancellationToken cancellationToken)
        {
            var signature=await _signatureReadRepository.GetByIdAsync(request.Id,false);
            var signatureDto= _mapper.Map<SignatureDTO>(signature);
            return new(){
                Signature=signatureDto
            };
        }
    }
}
