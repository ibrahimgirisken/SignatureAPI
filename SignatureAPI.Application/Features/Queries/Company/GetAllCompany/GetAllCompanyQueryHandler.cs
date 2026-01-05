using AutoMapper;
using MediatR;
using SignatureAPI.Application.DTOs.Company;
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
        readonly IMapper _mapper;
        public GetAllCompanyQueryHandler(ICompanyReadRepository companyReadRepository, IMapper mapper = null)
        {
            _companyReadRepository = companyReadRepository;
            _mapper = mapper;
        }

        public async Task<GetAllCompanyQueryResponse> Handle(GetAllCompanyQueryRequest request, CancellationToken cancellationToken)
        {
            var companies =_companyReadRepository.GetAll();
            var companiesDto=_mapper.Map<List<ResultCompanyDTO>>(companies);
            return new()
            {
                Companies = companiesDto
            };
        }
    }
}
