using AutoMapper;
using MediatR;
using SignatureAPI.Application.Repositories.CompanyComponent;

namespace SignatureAPI.Application.Features.Commands.CompanyComponent.CreateCompanyComponent
{
    public class CreateCompanyComponentCommandHandler : IRequestHandler<CreateCompanyComponentCommandRequest, CreateCompanyComponentCommandResponse>
    {
        readonly IMapper _mapper;
        readonly ICompanyComponentWriteRepository _companyComponentWriteRepository;

        public CreateCompanyComponentCommandHandler(IMapper mapper, ICompanyComponentWriteRepository companyComponentWriteRepository)
        {
            _mapper = mapper;
            _companyComponentWriteRepository = companyComponentWriteRepository;
        }

        public async Task<CreateCompanyComponentCommandResponse> Handle(CreateCompanyComponentCommandRequest request, CancellationToken cancellationToken)
        {
            if(request.CreateCompanyComponentDTO.CompanyId == Guid.Empty)
                throw new Exception("CompanyId is required");
            var CompanyComponent= _mapper.Map<Domain.Entities.CompanyComponent.CompanyComponent>(request.CreateCompanyComponentDTO);
            await _companyComponentWriteRepository.AddAsync(CompanyComponent);
            await _companyComponentWriteRepository.SaveAsync();
            return new();
        }
    }
}
