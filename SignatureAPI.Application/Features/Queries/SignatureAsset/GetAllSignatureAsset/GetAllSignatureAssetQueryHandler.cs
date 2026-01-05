using MediatR;
using SignatureAPI.Application.Repositories.SignatureAsset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Features.Queries.SignatureAsset.GetAllSignatureAsset
{
    public class GetAllSignatureAssetQueryHandler : IRequestHandler<GetAllSignatureAssetQueryRequest, GetAllSignatureAssetQueryResponse>
    {
        readonly ISignatureAssetReadRepository _signatureAssetReadRepository;
        readonly IMediator _mediator;

        public GetAllSignatureAssetQueryHandler(ISignatureAssetReadRepository signatureAssetReadRepository, IMediator mediator)
        {
            _signatureAssetReadRepository = signatureAssetReadRepository;
            _mediator = mediator;
        }

        public Task<GetAllSignatureAssetQueryResponse> Handle(GetAllSignatureAssetQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
