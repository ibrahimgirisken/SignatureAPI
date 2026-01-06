using AutoMapper;
using MediatR;
using SignatureAPI.Application.Repositories.Company;

namespace SignatureAPI.Application.Features.Commands.Company.UpdateCompany
{
    public class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommandRequest, UpdateCompanyCommandResponse>
    {
        readonly ICompanyWriteRepository _companyWriteRepository;
        readonly IMapper _mapper;

        public UpdateCompanyCommandHandler(ICompanyWriteRepository companyWriteRepository, IMapper mapper = null)
        {
            _companyWriteRepository = companyWriteRepository;
            _mapper = mapper;
        }

        async Task<UpdateCompanyCommandResponse> IRequestHandler<UpdateCompanyCommandRequest, UpdateCompanyCommandResponse>.Handle(UpdateCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            var company=_mapper.Map<Domain.Entities.Company.Company>(request);
            _companyWriteRepository.Update(company);
            await _companyWriteRepository.SaveAsync();
            return new();
        }
    }
}
