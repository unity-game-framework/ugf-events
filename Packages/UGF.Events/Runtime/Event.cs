using System;

namespace UGF.Events.Runtime
{
    public abstract class Event : EventDynamic, IEvent
    {
        public void Add(EventFunctionHandler handler)
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            OnAdd(handler);
        }

        public bool Remove(EventFunctionHandler handler)
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            return OnRemove(handler);
        }

        public void Invoke()
        {
            OnInvoke();
        }

        protected abstract void OnAdd(EventFunctionHandler handler);
        protected abstract bool OnRemove(EventFunctionHandler handler);
        protected abstract void OnInvoke();
    }
}
