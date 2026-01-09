
namespace SignatureAPI.Application.Exceptions
{
    public class PasswordChangeFailedException:Exception
    {
        public PasswordChangeFailedException():base("Şifre oluşturulurken bir hata oluştu.")
        {
            
        }

        public PasswordChangeFailedException(string message): base(message)
        {
            
        }

        public PasswordChangeFailedException(string? message,Exception? innerExcepiton):base(message, innerExcepiton)
        {
            
        }
    }
}
