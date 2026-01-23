using MediatR;
using SignatureAPI.Application.Repositories.CompanyComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Features.Commands.CompanyComponent.RemoveCompanyComponent
{
    public class RemoveCompanyComponentCommandHandler : IRequestHandler<RemoveCompanyComponentCommandRequest, RemoveCompanyComponentCommandResponse>
    {
        readonly ICompanyComponentWriteRepository _companyComponentWriteRepository;
        public async Task<RemoveCompanyComponentCommandResponse> Handle(RemoveCompanyComponentCommandRequest request, CancellationToken cancellationToken)
        {
            await _companyComponentWriteRepository.RemoveAsync(request.Id);
            return new();
        }
    }
}
