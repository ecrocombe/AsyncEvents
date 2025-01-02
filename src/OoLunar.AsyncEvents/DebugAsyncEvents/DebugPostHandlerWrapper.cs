using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace OoLunar.AsyncEvents.DebugAsyncEvents
{
    internal sealed class DebugPostHandlerWrapper<TEventArgs> where TEventArgs : AsyncEventArgs
    {
        public AsyncEventPostHandler<TEventArgs> PostHandler { get; init; }

        private readonly ILogger<DebugAsyncEvent<TEventArgs>> _logger;

        public DebugPostHandlerWrapper(AsyncEventPostHandler<TEventArgs> postHandler, ILogger<DebugAsyncEvent<TEventArgs>> logger)
        {
            PostHandler = postHandler;
            _logger = logger;
        }

        public async ValueTask StartPostHandlerAsync(TEventArgs eventArgs)
        {
            _logger.LogDebug("Started invoking post-handler '{Handler}'", PostHandler);
            await PostHandler(eventArgs);
            _logger.LogDebug("Finished invoking post-handler '{Handler}'", PostHandler);
        }
    }
}
