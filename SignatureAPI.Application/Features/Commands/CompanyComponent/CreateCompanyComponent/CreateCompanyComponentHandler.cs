using AutoMapper;
using MediatR;
using SignatureAPI.Application.Repositories.CompanyComponent;

namespace SignatureAPI.Application.Features.Commands.CompanyComponent.CreateCompanyComponent
{
    public class CreateCompanyComponentHandler : IRequestHandler<CreateCompanyComponentRequest, CreateCompanyComponentResponse>
    {
        readonly IMapper _mapper;
        readonly ICompanyComponentWriteRepository _companyComponentWriteRepository;

        public CreateCompanyComponentHandler(IMapper mapper, ICompanyComponentWriteRepository companyComponentWriteRepository)
        {
            _mapper = mapper;
            _companyComponentWriteRepository = companyComponentWriteRepository;
        }

        public async Task<CreateCompanyComponentResponse> Handle(CreateCompanyComponentRequest request, CancellationToken cancellationToken)
        {
            var CompanyComponent= _mapper.Map<Domain.Entities.CompanyComponent.CompanyComponent>(request);
            await _companyComponentWriteRepository.AddAsync(CompanyComponent);
            return new();
        }
    }
}
