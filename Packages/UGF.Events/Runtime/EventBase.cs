using System;

namespace UGF.Events.Runtime
{
    public abstract class EventBase : IEvent
    {
        public void Add(EventHandler handler)
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            OnAdd(handler);
        }

        public bool Remove(EventHandler handler)
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            return OnRemove(handler);
        }

        public void Invoke(object arguments)
        {
            if (arguments == null) throw new ArgumentNullException(nameof(arguments));

            OnInvoke(arguments);
        }

        protected abstract void OnAdd(EventHandler handler);
        protected abstract bool OnRemove(EventHandler handler);
        protected abstract void OnInvoke(object arguments);
    }
}
