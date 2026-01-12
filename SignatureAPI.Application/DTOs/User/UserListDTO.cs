
namespace SignatureAPI.Application.DTOs.User
{
    public class UserListDTO
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string NameSurname { get; set; }
        public string UserName { get; set; }
    }
}
