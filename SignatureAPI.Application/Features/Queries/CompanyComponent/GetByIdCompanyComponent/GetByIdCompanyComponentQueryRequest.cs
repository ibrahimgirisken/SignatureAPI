using MediatR;

namespace SignatureAPI.Application.Features.Queries.CompanyComponent.GetByIdCompanyComponent
{
    public class GetByIdCompanyComponentQueryRequest:IRequest<GetByIdCompanyComponentQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
