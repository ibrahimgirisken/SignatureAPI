using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignatureAPI.Application.Features.Commands.Company.CreateCompany;
using SignatureAPI.Application.Features.Commands.Company.RemoveCompany;
using SignatureAPI.Application.Features.Commands.Company.UpdateCompany;
using SignatureAPI.Application.Features.Queries.Company.GetAllCompany;
using System.Net;

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

        [HttpPost("add")]
        public async Task<IActionResult> CreateCompany(CreateCompanyCommandRequest createCompanyCommandRequest)
        {
            CreateCompanyCommandResponse response=await _mediator.Send(createCompanyCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateCompany(UpdateCompanyCommandRequest updateCompanyCommandRequest)
        {
            UpdateCompanyCommandResponse response = await _mediator.Send(updateCompanyCommandRequest);
            return StatusCode((int)HttpStatusCode.OK);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteCompany(RemoveCompanyCommandRequest removeCompanyCommandRequest)
        {
            RemoveCompanyCommandResponse response = await _mediator.Send(removeCompanyCommandRequest);
            return StatusCode((int)HttpStatusCode.OK);
        }
    }
}
