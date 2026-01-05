using AutoMapper;
using MediatR;
using SignatureAPI.Application.DTOs.Signature;
using SignatureAPI.Application.Repositories.SignatureAsset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Features.Queries.Signature.GetAllSignature
{
    public class GetAllSignatureQueryHandler:IRequestHandler<GetAllSignatureQueryRequest, GetAllSignatureQueryResponse>
    {
        readonly ISignatureAssetReadRepository _signatureAssetReadRepository;
        readonly IMapper _mapper;

        public GetAllSignatureQueryHandler(ISignatureAssetReadRepository signatureAssetReadRepository, IMapper mapper = null)
        {
            _signatureAssetReadRepository = signatureAssetReadRepository;
            _mapper = mapper;
        }

        public async Task<GetAllSignatureQueryResponse> Handle(GetAllSignatureQueryRequest request, CancellationToken cancellationToken)
        {
            var signatures = _signatureAssetReadRepository.GetAll();
            var signatureDto=_mapper.Map<List<ResultSignatureDTO>>(signatures);
            return new()
            {
                Signatures = signatureDto
            };
        }
    }
}
