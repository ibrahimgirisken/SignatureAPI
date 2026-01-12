
using Microsoft.AspNetCore.Identity;
using SignatureAPI.Application.Abstractions.Services;
using SignatureAPI.Application.DTOs.User;
using SignatureAPI.Application.Exceptions;
using SignatureAPI.Application.Features.Commands.AppUser.CreateUser;
using SignatureAPI.Application.Helpers;
using SignatureAPI.Domain.Entities.Identity;

namespace SignatureAPI.Persistence.Services
{
    public class UserService : IUserService
    {
        readonly UserManager<AppUser> _userManager;

        public UserService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public int TotalUserCount => _userManager.Users.Count();

        public async Task<CreateUserCommandResponse> CreateAsync(CreateUserDTO model)
        {
            IdentityResult result = await _userManager.CreateAsync(new()
            {
                Id=Guid.NewGuid(),
                UserName=model.UserName,
                Email = model.Email,
                NameSurname = model.NameSurname
            },model.Password);

            CreateUserCommandResponse response = new() { Succeeded = result.Succeeded };
            if (!result.Succeeded)
                response.Message = "Kullanıcı başarıyla oluşturulmuştur.";
            else
                foreach (var item in result.Errors)
                response.Message += $"{item.Code} - {item.Description}\n";

            return response;
        }

        public async Task<List<UserListDTO>> GetAllUsersAsync(int page, int size)
        {
            var users = _userManager.Users
                .Skip((page - 1) * size)
                .Take(size)
                .Select(u => new UserListDTO
                {
                    Id = u.Id,
                    Email = u.Email,
                    NameSurname = u.NameSurname,
                    UserName = u.UserName
                })
                .ToList();
            return await Task.FromResult(users);
        }

        public async Task UpdatePasswordAsync(string userId, string resetToken, string newPassword)
        {
            AppUser user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                resetToken = resetToken.UrlDecode();
                IdentityResult result = await _userManager.ResetPasswordAsync(user, resetToken, newPassword);
                if (result.Succeeded)
                    await _userManager.UpdateSecurityStampAsync(user);
                else
                    throw new PasswordChangeFailedException();
            }
        }
    }
}
