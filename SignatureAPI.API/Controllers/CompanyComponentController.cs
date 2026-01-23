using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignatureAPI.Application.Features.Commands.CompanyComponent.CreateCompanyComponent;
using SignatureAPI.Application.Features.Commands.CompanyComponent.RemoveCompanyComponent;
using SignatureAPI.Application.Features.Commands.CompanyComponent.UpdateCompanyComponent;
using SignatureAPI.Application.Features.Queries.CompanyComponent.GetAllCompanyComponent;
using SignatureAPI.Application.Features.Queries.CompanyComponent.GetByIdCompanyComponent;

namespace SignatureAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyComponentController : ControllerBase
    {
        readonly IMediator _mediator;

        public CompanyComponentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCompanyComponent([FromQuery] GetAllCompanyComponentQueryRequest getAllCompanyComponentRequest)
        {
            GetAllCompanyComponentQueryResponse response = await _mediator.Send(getAllCompanyComponentRequest);
            return Ok(response);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetByIdCompanyComponent([FromQuery] GetByIdCompanyComponentQueryRequest companyComponentQueryRequest)
        {
            GetByIdCompanyComponentQueryResponse response = await _mediator.Send(companyComponentQueryRequest);
            return Ok(response);
        }

        [HttpPost("add")]
        public async Task<IActionResult> CreateCompanyComponent(CreateCompanyComponentCommandRequest createCompanyComponentCommandRequest)
        {
            CreateCompanyComponentCommandResponse response = await _mediator.Send(createCompanyComponentCommandRequest);
            return Ok(response);
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateCompanyComponent(UpdateCompanyComponentCommandRequest updateCompanyComponentCommandRequest)
        {
            UpdateCompanyComponentCommandResponse response = await _mediator.Send(updateCompanyComponentCommandRequest);
            return Ok(response);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteCompanyComponent([FromQuery] RemoveCompanyComponentCommandRequest removeCompanyComponentCommandRequest)
        {
            RemoveCompanyComponentCommandResponse response = await _mediator.Send(removeCompanyComponentCommandRequest);
            return Ok(response);
        }

    }
}
