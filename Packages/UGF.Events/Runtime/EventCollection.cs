using System;
using System.Collections.Generic;

namespace UGF.Events.Runtime
{
    public abstract class EventCollection<TArguments> : Event<TArguments>
    {
        public override int Count { get { return Handlers.Count; } }
        protected ICollection<Delegate> Handlers { get; }

        protected EventCollection(ICollection<Delegate> handlers)
        {
            Handlers = handlers ?? throw new ArgumentNullException(nameof(handlers));
        }

        protected override void OnAdd(EventHandler handler)
        {
            Handlers.Add(handler);
        }

        protected override bool OnRemove(EventHandler handler)
        {
            return Handlers.Remove(handler);
        }

        protected override void OnAdd(EventHandler<TArguments> handler)
        {
            Handlers.Add(handler);
        }

        protected override bool OnRemove(EventHandler<TArguments> handler)
        {
            return Handlers.Remove(handler);
        }

        protected override void OnClear()
        {
            Handlers.Clear();
        }
    }
}
