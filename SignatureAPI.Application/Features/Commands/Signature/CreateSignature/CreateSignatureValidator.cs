using FluentValidation;
using SignatureAPI.Application.DTOs.Signature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Features.Commands.Signature.CreateSignature
{
    public class CreateSignatureValidator:AbstractValidator<CreateSignatureCommandRequest>
    {
        public CreateSignatureValidator()
        {
            RuleFor(x => x.Address)
                .NotEmpty().WithMessage("Adres alanı boş olmamalıdır.")
                .MinimumLength(100).WithMessage("En az 3 karakter içermelidir.");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Telefon alanı boş olmamalıdır.")
                .MinimumLength(10).WithMessage("En az 11 karakter içermelidir.");

            RuleFor(x => x.Fax)
                .NotEmpty().WithMessage("Fax alanı boş olmamalıdır.")
                .MinimumLength(10).WithMessage("En az 11 karakter içermelidir.");

            RuleFor(x => x.KdvText)
                .NotEmpty().WithMessage("KdvText alanı boş olmamalıdır.")
                .MinimumLength(10).WithMessage("En az 3 karakter içermelidir.");

            RuleFor(x => x.InformationText)
                .NotEmpty().WithMessage("InformationText alanı boş olmamalıdır.")
                .MinimumLength(10).WithMessage("En az 3 karakter içermelidir.");

            RuleFor(x => x.EnvironmentText)
                .NotEmpty().WithMessage("EnvironmentText alanı boş olmamalıdır.")
                .MinimumLength(10).WithMessage("En az 3 karakter içermelidir.");
        }
    }
}
