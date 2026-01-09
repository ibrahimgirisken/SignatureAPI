using MediatR;

namespace SignatureAPI.Application.Validators.ValidationBehavior
{
    public interface IValidationBehavior<TRequest, TResponse>
    {
        Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken);
    }
}