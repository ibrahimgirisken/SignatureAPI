using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Features.Queries.Signature.GetWhereSignature
{
    public class GetWhereSignatureQueryRequest:IRequest<GetWhereSignatureQueryResponse>
    {
        public Guid companyId { get; set; }
    }
}
