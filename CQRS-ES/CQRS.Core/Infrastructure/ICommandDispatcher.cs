

using CQRS.Core.Commands;

namespace CQRS.Core.Infrastructure
{
    public interface ICommandDispatcher
    {
        void RegsiterHandler<T>(Func<T, Task> handler) where T : BaseCommand;
        Task SendAsync(BaseCommand command);
    }
}