using System;
using System.Collections.Generic;

namespace UGF.Events.Runtime
{
    public abstract class EventCollection<TCollection, TArguments> : Event<TArguments> where TCollection : ICollection<EventHandler<TArguments>>
    {
        protected TCollection Collection { get; }

        protected EventCollection(TCollection collection)
        {
            Collection = collection ?? throw new ArgumentNullException(nameof(collection));
        }

        protected override void OnAdd(Delegate handler)
        {
            OnAdd((EventHandler<TArguments>)handler);
        }

        protected override bool OnRemove(Delegate handler)
        {
            return OnRemove((EventHandler<TArguments>)handler);
        }

        protected override void OnAdd(EventHandler<TArguments> handler)
        {
            Collection.Add(handler);
        }

        protected override bool OnRemove(EventHandler<TArguments> handler)
        {
            return Collection.Remove(handler);
        }

        protected override void OnClear()
        {
            Collection.Clear();
        }

        protected override void OnInvoke(object arguments)
        {
            OnInvoke((TArguments)arguments);
        }
    }
}
