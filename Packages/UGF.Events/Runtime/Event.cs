using System;

namespace UGF.Events.Runtime
{
    public abstract class Event : EventDynamic, IEvent
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

        public void Invoke()
        {
            OnInvoke();
        }

        protected abstract void OnAdd(EventHandler handler);
        protected abstract bool OnRemove(EventHandler handler);
        protected abstract void OnInvoke();
    }
}
