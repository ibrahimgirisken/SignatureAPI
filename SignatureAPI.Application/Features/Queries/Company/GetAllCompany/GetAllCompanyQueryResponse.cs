using SignatureAPI.Application.DTOs.Company;

namespace SignatureAPI.Application.Features.Queries.Company.GetAllCompany
{
    public class GetAllCompanyQueryResponse
    {
        public List<ResultCompanyDTO> Companies{ get; set; }
    }
}
