using MediatR;
using SignatureAPI.Application.Repositories.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Features.Queries.Company.GetAllCompany
{
    public class GetAllCompanyQueryHandler:IRequestHandler<GetAllCompanyQueryRequest, GetAllCompanyQueryResponse>
    {
        readonly ICompanyReadRepository _companyReadRepository;
        readonly IMediator _mediator;

        public GetAllCompanyQueryHandler(ICompanyReadRepository companyReadRepository, IMediator mediator)
        {
            _companyReadRepository = companyReadRepository;
            _mediator = mediator;
        }

        public Task<GetAllCompanyQueryResponse> Handle(GetAllCompanyQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
