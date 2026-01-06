using MediatR;
using SignatureAPI.Application.Repositories.Company;

namespace SignatureAPI.Application.Features.Commands.Company.RemoveCompany
{
    public class RemoveCompanyCommandHandler : IRequestHandler<RemoveCompanyCommandRequest, RemoveCompanyCommandResponse>
    {
        readonly ICompanyWriteRepository _companyWriteRepository;

        public RemoveCompanyCommandHandler(ICompanyWriteRepository companyWriteRepository)
        {
            _companyWriteRepository = companyWriteRepository;
        }

        async Task<RemoveCompanyCommandResponse> IRequestHandler<RemoveCompanyCommandRequest, RemoveCompanyCommandResponse>.Handle(RemoveCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            await _companyWriteRepository.RemoveAsync(request.Id);
            await _companyWriteRepository.SaveAsync();
            return new();
        }
    }
}
