using UGF.Initialize.Runtime;

namespace UGF.Events.Runtime
{
    public interface IEventDispatcher<TArguments> : IInitialize
    {
        object Sender { get; }

        event EventDispatcherInvokeArgumentsHandler<TArguments> Invoked;

        IEventDispatcherInvokeHandler Invoke(TArguments arguments);
        IEventDispatcherInvokeHandler Invoke(IEventDispatcherInvokeHandler handler, TArguments arguments);
        T GetSender<T>() where T : class;
        bool TryGetSender<T>(out T sender) where T : class;
    }
}
