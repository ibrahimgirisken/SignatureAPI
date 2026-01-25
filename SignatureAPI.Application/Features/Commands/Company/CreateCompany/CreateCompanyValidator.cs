using FluentValidation;

namespace SignatureAPI.Application.Features.Commands.Company.CreateCompany
{
    public class CreateCompanyValidator:AbstractValidator<CreateCompanyCommandRequest>
    {
        public CreateCompanyValidator()
        {
            RuleFor(x=>x.CompanyName).NotEmpty();
        }
    }
}
