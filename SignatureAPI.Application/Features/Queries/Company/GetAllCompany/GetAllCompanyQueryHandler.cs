using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SignatureAPI.Application.DTOs.Company;
using SignatureAPI.Application.Repositories.Company;

namespace SignatureAPI.Application.Features.Queries.Company.GetAllCompany
{
    public class GetAllCompanyQueryHandler:IRequestHandler<GetAllCompanyQueryRequest, GetAllCompanyQueryResponse>
    {
        readonly ICompanyReadRepository _companyReadRepository;
        readonly IMapper _mapper;
        public GetAllCompanyQueryHandler(ICompanyReadRepository companyReadRepository, IMapper mapper = null)
        {
            _companyReadRepository = companyReadRepository;
            _mapper = mapper;
        }

        public async Task<GetAllCompanyQueryResponse> Handle(GetAllCompanyQueryRequest request, CancellationToken cancellationToken)
        {
            var companies =_companyReadRepository.Table.Include(x=>x.CompanyComponents).ToList();
            var companiesDto=_mapper.Map<List<CompanyDTO>>(companies);
            return new()
            {
                Companies = companiesDto
            };
        }
    }
}
