using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SignatureAPI.Application.DTOs.Signature;
using SignatureAPI.Application.Repositories.Signature;

namespace SignatureAPI.Application.Features.Queries.Signature.GetWhereSignature
{
    public class GetWhereSignatureQueryHandler : IRequestHandler<GetWhereSignatureQueryRequest, GetWhereSignatureQueryResponse>
    {
        readonly ISignatureReadRepository _signatureReadRepository;
        readonly IMapper _mapper;

        public GetWhereSignatureQueryHandler(ISignatureReadRepository signatureReadRepository, IMapper mapper)
        {
            _signatureReadRepository = signatureReadRepository;
            _mapper = mapper;
        }

        public async Task<GetWhereSignatureQueryResponse> Handle(GetWhereSignatureQueryRequest request, CancellationToken cancellationToken)
        {
            var signature=await _signatureReadRepository.GetWhere(sig=>sig.CompanyId==request.companyId,false).FirstOrDefaultAsync();
            var signatureDto= _mapper.Map<SignatureDTO>(signature);
            return new()
            {
                Signature = signatureDto
            };
        }
    }
}
