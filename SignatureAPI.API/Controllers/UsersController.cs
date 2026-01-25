using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SignatureAPI.Application.Features.Commands.AppUser.CreateUser;
using SignatureAPI.Application.Features.Queries.AppUser.GetAllUser;

namespace SignatureAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = "Admin")]
        public async Task<IActionResult> GetAllUsers([FromQuery]GetAllUserQueryRequest getAllUserQueryRequest)
        {
            GetAllUserQueryResponse response=await _mediator.Send(getAllUserQueryRequest);
            return Ok(response.UserListDTO);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommandRequest createUserCommandRequest)
        {
            CreateUserCommandResponse response =await _mediator.Send(createUserCommandRequest);
            return Ok(response);
        }
    }
}
