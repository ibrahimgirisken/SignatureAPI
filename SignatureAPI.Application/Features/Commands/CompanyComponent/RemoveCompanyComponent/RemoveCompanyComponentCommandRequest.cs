using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Features.Commands.CompanyComponent.RemoveCompanyComponent
{
    public class RemoveCompanyComponentCommandRequest:IRequest<RemoveCompanyComponentCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
