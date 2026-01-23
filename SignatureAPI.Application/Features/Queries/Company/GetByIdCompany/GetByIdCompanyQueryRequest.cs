using MediatR;

namespace SignatureAPI.Application.Features.Queries.Company.GetByIdCompany
{
    public class GetByIdCompanyQueryRequest:IRequest<GetByIdCompanyQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
