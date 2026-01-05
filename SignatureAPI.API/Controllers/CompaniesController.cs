using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignatureAPI.Application.Features.Queries.Company.GetAllCompany;

namespace SignatureAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        readonly IMediator _mediator;

        public CompaniesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllCompanies([FromQuery]GetAllCompanyQueryRequest getAllCompanyQueryRequest)
        {
            GetAllCompanyQueryResponse response= await _mediator.Send(getAllCompanyQueryRequest);
            return Ok(response);
        }
    }
}
