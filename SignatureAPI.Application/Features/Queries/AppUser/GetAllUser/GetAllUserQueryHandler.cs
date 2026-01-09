using AutoMapper;
using MediatR;
using SignatureAPI.Application.Abstractions.Services;
using SignatureAPI.Application.DTOs.User;

namespace SignatureAPI.Application.Features.Queries.AppUser.GetAllUser
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQueryRequest, GetAllUserQueryResponse>
    {
        readonly IUserService _userService;
        readonly IMapper _mapper;

        public GetAllUserQueryHandler(IUserService userService, IMapper mapper = null)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public async Task<GetAllUserQueryResponse> Handle(GetAllUserQueryRequest request, CancellationToken cancellationToken)
        {
            var users= await _userService.GetAllUsersAsync(request.Page,request.Size);
            var userList= _mapper.Map<List<UserListDTO>>(users);
            return new()
            {
                UserListDTO = userList
            };
        }
    }
}
