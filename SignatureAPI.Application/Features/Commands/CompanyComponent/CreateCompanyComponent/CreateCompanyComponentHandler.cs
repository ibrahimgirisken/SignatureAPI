using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Features.Commands.CompanyComponent.CreateCompanyComponent
{
    public class CreateCompanyComponentHandler : IRequestHandler<CreateCompanyComponentRequest, CreateCompanyComponentResponse>
    {
        public Task<CreateCompanyComponentResponse> Handle(CreateCompanyComponentRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
