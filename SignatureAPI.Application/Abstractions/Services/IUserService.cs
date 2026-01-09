using SignatureAPI.Application.DTOs.User;
using SignatureAPI.Application.Features.Commands.AppUser.CreateUser;

namespace SignatureAPI.Application.Abstractions.Services
{
    public interface IUserService
    {
        Task<CreateUserCommandResponse> CreateAsync(CreateUserDTO model);
        Task UpdatePasswordAsync(string userId, string resetToken, string newPassword);
        Task<List<UserListDTO>>  GetAllUsersAsync(int page,int size);
        int TotalUserCount { get; }
    }
}
