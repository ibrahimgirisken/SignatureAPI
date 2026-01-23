using AutoMapper;
using MediatR;
using SignatureAPI.Application.DTOs.Company;
using SignatureAPI.Application.Repositories.Company;

namespace SignatureAPI.Application.Features.Queries.Company.GetByIdCompany
{
    public class GetByIdCompanyQueryHandler : IRequestHandler<GetByIdCompanyQueryRequest, GetByIdCompanyQueryResponse>
    {
        readonly ICompanyReadRepository _companyReadRepository;
        readonly IMapper _mapper;

        public GetByIdCompanyQueryHandler(IMapper mapper = null, ICompanyReadRepository companyReadRepository = null)
        {
            _mapper = mapper;
            _companyReadRepository = companyReadRepository;
        }

        public async Task<GetByIdCompanyQueryResponse> Handle(GetByIdCompanyQueryRequest request, CancellationToken cancellationToken)
        {
            var Company= await _companyReadRepository.GetByIdAsync(request.Id);
            var CompanyDTO= _mapper.Map<CompanyDTO>(Company);
            return new()
            {
                CompanyDTO = CompanyDTO
            };
        }
    }
}
