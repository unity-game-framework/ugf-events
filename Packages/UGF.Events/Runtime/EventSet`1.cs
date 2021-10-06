using System.Collections.Generic;

namespace UGF.Events.Runtime
{
    public class EventSet<TArguments> : EventCollection<HashSet<EventHandler<TArguments>>, TArguments>
    {
        private readonly HashSet<EventHandler<TArguments>> m_invoke = new HashSet<EventHandler<TArguments>>();

        public EventSet() : this(new HashSet<EventHandler<TArguments>>())
        {
        }

        public EventSet(HashSet<EventHandler<TArguments>> collection) : base(collection)
        {
        }

        protected override void OnInvoke(TArguments arguments)
        {
            foreach (EventHandler<TArguments> handler in Collection)
            {
                m_invoke.Add(handler);
            }

            foreach (EventHandler<TArguments> handler in m_invoke)
            {
                handler.Invoke(arguments);
            }

            m_invoke.Clear();
        }
    }
}
