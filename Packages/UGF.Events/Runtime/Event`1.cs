using System;

namespace UGF.Events.Runtime
{
    public abstract class Event<TArguments> : EventDynamic, IEvent<TArguments>
    {
        public void Add(EventFunctionHandler<TArguments> handler)
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            OnAdd(handler);
        }

        public bool Remove(EventFunctionHandler<TArguments> handler)
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            return OnRemove(handler);
        }

        public void Invoke(TArguments arguments)
        {
            OnInvoke(arguments);
        }

        protected abstract void OnAdd(EventFunctionHandler<TArguments> handler);
        protected abstract bool OnRemove(EventFunctionHandler<TArguments> handler);
        protected abstract void OnInvoke(TArguments arguments);
    }
}
