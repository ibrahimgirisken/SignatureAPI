using MediatR;
using SignatureAPI.Application.Repositories.CompanyComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Features.Commands.CompanyComponent.RemoveCompanyComponent
{
    public class RemoveCompanyComponentHandler : IRequestHandler<RemoveCompanyComponentRequest, RemoveCompanyComponentResponse>
    {
        readonly ICompanyComponentWriteRepository _companyComponentWriteRepository;
        public async Task<RemoveCompanyComponentResponse> Handle(RemoveCompanyComponentRequest request, CancellationToken cancellationToken)
        {
            await _companyComponentWriteRepository.RemoveAsync(request.Id);
            return new();
        }
    }
}
