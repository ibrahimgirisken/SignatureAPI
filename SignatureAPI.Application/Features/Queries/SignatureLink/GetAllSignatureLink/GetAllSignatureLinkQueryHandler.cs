using MediatR;
using SignatureAPI.Application.Repositories.SignatureLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Features.Queries.SignatureLink.GetAllSignatureLink
{
    public class GetAllSignatureLinkQueryHandler : IRequestHandler<GetAllSignatureLinkQueryRequest, GetAllSignatureLinkQueryResponse>
    {
        readonly ISignatureLinkReadRepository _signatureLinkReadRepository;
        readonly IMediator _mediator;

        public GetAllSignatureLinkQueryHandler(ISignatureLinkReadRepository signatureLinkReadRepository, IMediator mediator)
        {
            _signatureLinkReadRepository = signatureLinkReadRepository;
            _mediator = mediator;
        }

        public Task<GetAllSignatureLinkQueryResponse> Handle(GetAllSignatureLinkQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
