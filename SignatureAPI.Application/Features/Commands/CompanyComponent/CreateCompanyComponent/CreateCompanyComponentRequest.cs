using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Features.Commands.CompanyComponent.CreateCompanyComponent
{
    public class CreateCompanyComponentRequest:IRequest<CreateCompanyComponentResponse>
    {
    }
}
