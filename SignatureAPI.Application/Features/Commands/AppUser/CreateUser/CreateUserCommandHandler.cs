using AutoMapper;
using MediatR;
using SignatureAPI.Application.Abstractions.Services;

namespace SignatureAPI.Application.Features.Commands.AppUser.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        readonly IUserService _userService;
        readonly IMapper _mapper;

        public CreateUserCommandHandler(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            var user=_mapper.Map<DTOs.User.CreateUserDTO>(request);
            await _userService.CreateAsync(user);
            return new();
        }
    }
}
