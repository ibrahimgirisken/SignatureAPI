using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Features.Commands.Company.CreateCompany
{
    public class CreateCompanyCommandRequest:IRequest<CreateCompanyCommandResponse>
    {
        public string CompanyName { get; set; }
    }
}
