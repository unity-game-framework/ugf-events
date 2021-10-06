using System;
using System.Collections.Generic;

namespace UGF.Events.Runtime
{
    public abstract class EventCollection<TCollection> : Event where TCollection : ICollection<EventFunctionHandler>
    {
        protected TCollection Collection { get; }

        protected EventCollection(TCollection collection)
        {
            Collection = collection ?? throw new ArgumentNullException(nameof(collection));
        }

        protected override void OnAdd(Delegate handler)
        {
            OnAdd((EventFunctionHandler)handler);
        }

        protected override bool OnRemove(Delegate handler)
        {
            return OnRemove((EventFunctionHandler)handler);
        }

        protected override void OnAdd(EventFunctionHandler handler)
        {
            Collection.Add(handler);
        }

        protected override bool OnRemove(EventFunctionHandler handler)
        {
            return Collection.Remove(handler);
        }

        protected override void OnClear()
        {
            Collection.Clear();
        }

        protected override void OnInvoke(object arguments)
        {
            OnInvoke();
        }
    }
}
