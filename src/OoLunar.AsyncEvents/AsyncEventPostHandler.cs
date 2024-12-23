using System.Threading.Tasks;

namespace OoLunar.AsyncEvents
{
    /// <summary>
    /// A non-generic form of <see cref="AsyncEventPostHandler{T}"/>.
    /// </summary>
    /// <param name="eventArgs">The event arguments.</param>
    /// <returns>A <see cref="ValueTask"/> representing the asynchronous operation.</returns>
    public delegate ValueTask AsyncEventPostHandler(AsyncEventArgs eventArgs);

    /// <summary>
    /// Represents a method/delegate that handles an asynchronous event.
    /// </summary>
    /// <param name="eventArgs">The event arguments.</param>
    /// <typeparam name="T">The type of the event arguments.</typeparam>
    /// <returns>A <see cref="ValueTask"/> representing the asynchronous operation.</returns>
    public delegate ValueTask AsyncEventPostHandler<T>(T eventArgs) where T : AsyncEventArgs;
}