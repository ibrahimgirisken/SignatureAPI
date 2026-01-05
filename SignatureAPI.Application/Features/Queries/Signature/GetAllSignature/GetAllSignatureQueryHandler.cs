using MediatR;
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
        readonly IMediator _mediator;

        public GetAllSignatureQueryHandler(ISignatureAssetReadRepository signatureAssetReadRepository, IMediator mediator)
        {
            _signatureAssetReadRepository = signatureAssetReadRepository;
            _mediator = mediator;
        }

        public Task<GetAllSignatureQueryResponse> Handle(GetAllSignatureQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
