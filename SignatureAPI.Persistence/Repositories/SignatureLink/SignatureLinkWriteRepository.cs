using SignatureAPI.Application.Repositories.SignatureLink;
using SignatureAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Persistence.Repositories.SignatureLink
{
    public class SignatureLinkWriteRepository : WriteRepository<Domain.Entities.Signature.SignatureLink>, ISignatureLinkWriteRepository
    {
        public SignatureLinkWriteRepository(SignatureAPIDbContext context) : base(context)
        {
        }
    }
}
