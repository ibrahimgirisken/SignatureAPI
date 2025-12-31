using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Repositories.Signature
{
    public interface ISignatureWriteRepository:IWriteRepository<Domain.Entities.Signature.Signature>
    {
    }
}
