using SignatureAPI.Application.DTOs.Company;

namespace SignatureAPI.Application.Features.Queries.CompanyComponent.GetAllCompanyComponent
{
    public class GetAllCompanyComponentQueryResponse
    {
        public List<CompanyComponentDTO> CompanyComponentDTOs{ get; set; }
    }
}
