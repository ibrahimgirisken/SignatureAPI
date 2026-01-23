using AutoMapper;
using MediatR;
using SignatureAPI.Application.Repositories.Company;

namespace SignatureAPI.Application.Features.Commands.Company.CreateCompany
{
    public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommandRequest, CreateCompanyCommandResponse>
    {
        readonly ICompanyWriteRepository _companyWriteRepository;
        readonly IMapper _mapper;

        public CreateCompanyCommandHandler(ICompanyWriteRepository companyWriteRepository, IMapper mapper)
        {
            _companyWriteRepository = companyWriteRepository;
            _mapper = mapper;
        }

        async Task<CreateCompanyCommandResponse> IRequestHandler<CreateCompanyCommandRequest, CreateCompanyCommandResponse>.Handle(CreateCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            var company=_mapper.Map<Domain.Entities.Company.Company>(request.CreateCompanyDTO);
            await _companyWriteRepository.AddAsync(company);
            await _companyWriteRepository.SaveAsync();
            return new() { 
            };
        }
    }
}
