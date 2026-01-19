using MediatR;

namespace SignatureAPI.Application.Features.Queries.Signature.GetByIdSignature
{
    public class GetByIdSignatureQueryRequest:IRequest<GetByIdSignatureQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
