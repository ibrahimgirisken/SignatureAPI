using AutoMapper;
using MediatR;
using SignatureAPI.Application.DTOs.CompanyComponent;
using SignatureAPI.Application.Repositories.CompanyComponent;

namespace SignatureAPI.Application.Features.Queries.CompanyComponent.GetAllCompanyComponent
{
    public class GetAllCompanyComponentQueryHandler : IRequestHandler<GetAllCompanyComponentQueryRequest, GetAllCompanyComponentQueryResponse>
    {
        readonly ICompanyComponentReadRepository _companyComponentReadRepository;
        readonly IMapper _mapper;

        public GetAllCompanyComponentQueryHandler(ICompanyComponentReadRepository companyComponentReadRepository, IMapper mapper)
        {
            _companyComponentReadRepository = companyComponentReadRepository;
            _mapper = mapper;
        }

        public async Task<GetAllCompanyComponentQueryResponse> Handle(GetAllCompanyComponentQueryRequest request, CancellationToken cancellationToken)
        {
            var companyComponents = _companyComponentReadRepository.GetAll();
            var response=_mapper.Map<List<CompanyComponentDTO>>(companyComponents);
            return new()
            {
               CompanyComponentDTOs= response
            };
        }
    }
}
