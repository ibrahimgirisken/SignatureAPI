using AutoMapper;
using MediatR;
using SignatureAPI.Application.Repositories.Company;

namespace SignatureAPI.Application.Features.Commands.Company.UpdateCompany
{
    public class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommandRequest, UpdateCompanyCommandResponse>
    {
        readonly ICompanyWriteRepository _companyWriteRepository;
        readonly ICompanyReadRepository _companyReadRepository;
        readonly IMapper _mapper;

        public UpdateCompanyCommandHandler(ICompanyWriteRepository companyWriteRepository, IMapper mapper = null, ICompanyReadRepository companyReadRepository = null)
        {
            _companyWriteRepository = companyWriteRepository;
            _mapper = mapper;
            _companyReadRepository = companyReadRepository;
        }

        async Task<UpdateCompanyCommandResponse> IRequestHandler<UpdateCompanyCommandRequest, UpdateCompanyCommandResponse>.Handle(UpdateCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            var company=await _companyReadRepository.GetByIdAsync(request.Id);
            _mapper.Map(request,company);
            await _companyWriteRepository.SaveAsync();
            return new();
        }
    }
}
