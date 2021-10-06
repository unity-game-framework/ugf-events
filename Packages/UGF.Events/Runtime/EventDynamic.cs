using System;

namespace UGF.Events.Runtime
{
    public abstract class EventDynamic : IEventDynamic
    {
        public void Add(Delegate handler)
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            OnAdd(handler);
        }

        public bool Remove(Delegate handler)
        {
            return OnRemove(handler);
        }

        public void Clear()
        {
            OnClear();
        }

        public void Invoke(object arguments)
        {
            if (arguments == null) throw new ArgumentNullException(nameof(arguments));

            OnInvoke(arguments);
        }

        protected abstract void OnAdd(Delegate handler);
        protected abstract bool OnRemove(Delegate handler);
        protected abstract void OnClear();
        protected abstract void OnInvoke(object arguments);
    }
}
