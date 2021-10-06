using System;

namespace UGF.Events.Runtime
{
    public abstract class Event<TArguments> : EventDynamic, IEvent<TArguments>
    {
        public void Add(EventHandler<TArguments> handler)
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            OnAdd(handler);
        }

        public bool Remove(EventHandler<TArguments> handler)
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            return OnRemove(handler);
        }

        public void Invoke(TArguments arguments)
        {
            OnInvoke(arguments);
        }

        protected abstract void OnAdd(EventHandler<TArguments> handler);
        protected abstract bool OnRemove(EventHandler<TArguments> handler);
        protected abstract void OnInvoke(TArguments arguments);
    }
}
