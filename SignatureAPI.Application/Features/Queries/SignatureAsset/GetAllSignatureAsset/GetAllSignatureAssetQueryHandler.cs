using AutoMapper;
using MediatR;
using SignatureAPI.Application.DTOs.Signature;
using SignatureAPI.Application.Repositories.SignatureAsset;

namespace SignatureAPI.Application.Features.Queries.SignatureAsset.GetAllSignatureAsset
{
    public class GetAllSignatureAssetQueryHandler : IRequestHandler<GetAllSignatureAssetQueryRequest, GetAllSignatureAssetQueryResponse>
    {
        readonly ISignatureAssetReadRepository _signatureAssetReadRepository;
        readonly IMapper _mapper;

        public GetAllSignatureAssetQueryHandler(ISignatureAssetReadRepository signatureAssetReadRepository, IMapper mapper)
        {
            _signatureAssetReadRepository = signatureAssetReadRepository;
            _mapper = mapper;
        }

        public async Task<GetAllSignatureAssetQueryResponse> Handle(GetAllSignatureAssetQueryRequest request, CancellationToken cancellationToken)
        {
            var signatureAssetList = _signatureAssetReadRepository.GetAll();
            var signatureAssetsDto= _mapper.Map<List<SignatureAssetDTO>>(signatureAssetList);
            return new()
            {
                SignatureAssets = signatureAssetsDto
            };
        }
    }
}
