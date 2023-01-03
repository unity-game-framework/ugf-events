using System;
using UGF.Initialize.Runtime;

namespace UGF.Events.Runtime
{
    public class EventDispatcher<TArguments> : Initializable, IEventDispatcher<TArguments>
    {
        public object Sender { get; }

        public event EventDispatcherInvokeArgumentsHandler<TArguments> Invoked;

        public EventDispatcher(object sender)
        {
            Sender = sender ?? throw new ArgumentNullException(nameof(sender));
        }

        public IEventDispatcherInvokeHandler Invoke(TArguments arguments)
        {
            return Invoke(new EventDispatcherInvokeHandler(), arguments);
        }

        public IEventDispatcherInvokeHandler Invoke(IEventDispatcherInvokeHandler handler, TArguments arguments)
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));
            if (arguments == null) throw new ArgumentNullException(nameof(arguments));

            handler = OnInvoke(handler, arguments);

            Invoked?.Invoke(this, handler, arguments);

            return handler;
        }

        public T GetSender<T>() where T : class
        {
            return (T)Sender;
        }

        public bool TryGetSender<T>(out T sender) where T : class
        {
            sender = Sender as T;
            return sender != null;
        }

        protected virtual IEventDispatcherInvokeHandler OnInvoke(IEventDispatcherInvokeHandler handler, TArguments arguments)
        {
            return handler;
        }
    }
}
