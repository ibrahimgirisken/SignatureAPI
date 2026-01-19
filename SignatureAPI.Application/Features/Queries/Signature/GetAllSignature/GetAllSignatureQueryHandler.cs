using AutoMapper;
using MediatR;
using SignatureAPI.Application.DTOs.Signature;
using SignatureAPI.Application.Repositories.Signature;

namespace SignatureAPI.Application.Features.Queries.Signature.GetAllSignature
{
    public class GetAllSignatureQueryHandler:IRequestHandler<GetAllSignatureQueryRequest, GetAllSignatureQueryResponse>
    {
        readonly ISignatureReadRepository _signatureReadRepository;
        readonly IMapper _mapper;

        public GetAllSignatureQueryHandler(ISignatureReadRepository signatureReadRepository, IMapper mapper)
        {
            _signatureReadRepository = signatureReadRepository;
            _mapper = mapper;
        }

        public async Task<GetAllSignatureQueryResponse> Handle(GetAllSignatureQueryRequest request, CancellationToken cancellationToken)
        {
            var signatures = _signatureReadRepository.GetAll();
            var signatureDto=_mapper.Map<List<SignatureDTO>>(signatures);
            return new()
            {
                Signatures = signatureDto
            };
        }
    }
}
