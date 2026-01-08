using MediatR;
using SignatureAPI.Application.DTOs.Signature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Features.Commands.Signature.UpdateSignature
{
    public class UpdateSignatureCommandRequest:IRequest<UpdateSignatureCommandResponse>
    {
        public Guid Id { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Address { get; set; }
        public string? KdvText { get; set; }
        public string? InformationText { get; set; }
        public string? EnvironmentText { get; set; }
        public Guid? CompanyId { get; set; }
    }
}
