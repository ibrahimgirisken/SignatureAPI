using SignatureAPI.Application.DTOs.User;
using SignatureAPI.Application.Features.Commands.AppUser.CreateUser;
using SignatureAPI.Domain.Entities.Identity;

namespace SignatureAPI.Application.Abstractions.Services
{
    public interface IUserService
    {
        Task<CreateUserCommandResponse> CreateAsync(CreateUserDTO model);
        Task UpdatePasswordAsync(string userId, string resetToken, string newPassword);
        Task<List<UserListDTO>>  GetAllUsersAsync(int page,int size);
        Task UpdateRefreshTokenAsync(string refreshToken, AppUser user, DateTime accessTokenDate, int addOnAccessTokenDate);

        int TotalUserCount { get; }
    }
}
