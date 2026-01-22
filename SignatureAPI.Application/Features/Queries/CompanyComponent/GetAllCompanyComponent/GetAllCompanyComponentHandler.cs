using AutoMapper;
using MediatR;
using SignatureAPI.Application.DTOs.Company;
using SignatureAPI.Application.Repositories.CompanyComponent;

namespace SignatureAPI.Application.Features.Queries.CompanyComponent.GetAllCompanyComponent
{
    public class GetAllCompanyComponentHandler : IRequestHandler<GetAllCompanyComponentRequest, GetAllCompanyComponentResponse>
    {
        readonly ICompanyComponentReadRepository _companyComponentReadRepository;
        readonly IMapper _mapper;

        public GetAllCompanyComponentHandler(ICompanyComponentReadRepository companyComponentReadRepository, IMapper mapper)
        {
            _companyComponentReadRepository = companyComponentReadRepository;
            _mapper = mapper;
        }

        public async Task<GetAllCompanyComponentResponse> Handle(GetAllCompanyComponentRequest request, CancellationToken cancellationToken)
        {
            var companyComponents = _companyComponentReadRepository.GetAll();
            var response=_mapper.Map<List<ResultCompanyComponentDTO>>(companyComponents);
            return new()
            {
               CompanyComponentDTOs= response
            };
        }
    }
}
