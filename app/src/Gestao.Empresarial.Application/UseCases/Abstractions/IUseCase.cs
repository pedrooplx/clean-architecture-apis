using System.Threading.Tasks;

namespace Gestao.Empresarial.Application.UseCases.Abstractions
{
    public interface IUseCase<in TRequest>
    {
        void Execute(TRequest request);
    }
    public interface IUseCaseAsync<in TRequest>
    {
        Task ExecuteAsync(TRequest request);
    }
    public interface IUseCaseAsync<TRequest, TResponse>
    {
        Task<TResponse> ExecuteAsync(TRequest request);
    }
}
