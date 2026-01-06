using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Features.Commands.SignatureLink.CreateSignatureLink
{
    public class CreateSignatureLinkCommandRequest:IRequest<CreateSignatureLinkCommandResponse>
    {
    }
}
