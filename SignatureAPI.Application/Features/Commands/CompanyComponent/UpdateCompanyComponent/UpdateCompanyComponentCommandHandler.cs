using AutoMapper;
using MediatR;
using SignatureAPI.Application.Repositories.CompanyComponent;

namespace SignatureAPI.Application.Features.Commands.CompanyComponent.UpdateCompanyComponent
{
    public class UpdateCompanyComponentCommandHandler : IRequestHandler<UpdateCompanyComponentCommandRequest, UpdateCompanyComponentCommandResponse>
    {
        readonly ICompanyComponentWriteRepository _companyComponentWriteRepository;
        readonly ICompanyComponentReadRepository _companyComponentReadRepository;
        readonly IMapper _mapper;

        public UpdateCompanyComponentCommandHandler(ICompanyComponentWriteRepository companyComponentWriteRepository, ICompanyComponentReadRepository companyComponentReadRepository, IMapper mapper)
        {
            _companyComponentWriteRepository = companyComponentWriteRepository;
            _companyComponentReadRepository = companyComponentReadRepository;
            _mapper = mapper;
        }

        public async Task<UpdateCompanyComponentCommandResponse> Handle(UpdateCompanyComponentCommandRequest request, CancellationToken cancellationToken)
        {
            var companyComponent = _companyComponentReadRepository.GetByIdAsync(request.UpdateCompanyComponentDTO.Id);
            _mapper.Map(request.UpdateCompanyComponentDTO, companyComponent);
            await _companyComponentWriteRepository.SaveAsync();
            return new();
        }
    }
}
