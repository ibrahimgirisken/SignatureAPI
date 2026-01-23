using AutoMapper;
using MediatR;
using SignatureAPI.Application.Repositories.CompanyComponent;

namespace SignatureAPI.Application.Features.Queries.CompanyComponent.GetByIdCompanyComponent
{
    public class GetByIdCompanyComponentQueryHandler : IRequestHandler<GetByIdCompanyComponentQueryRequest, GetByIdCompanyComponentQueryResponse>
    {
        readonly ICompanyComponentReadRepository _companyComponentReadRepository;
        readonly IMapper _mapper;

        public GetByIdCompanyComponentQueryHandler(ICompanyComponentReadRepository companyComponentReadRepository, IMapper mapper)
        {
            _companyComponentReadRepository = companyComponentReadRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdCompanyComponentQueryResponse> Handle(GetByIdCompanyComponentQueryRequest request, CancellationToken cancellationToken)
        {
            var companyComponent= await _companyComponentReadRepository.GetByIdAsync(request.Id);
            var companyComponentDTO = _mapper.Map<SignatureAPI.Application.DTOs.CompanyComponent.CompanyComponentDTO>(companyComponent);
            return new()
            {
                CompanyComponentDTO = companyComponentDTO
            };
        }
    }
}
