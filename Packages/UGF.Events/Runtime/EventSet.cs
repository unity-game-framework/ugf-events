using System;
using System.Collections.Generic;

namespace UGF.Events.Runtime
{
    public class EventSet : EventCollection<HashSet<EventHandler>>
    {
        private readonly HashSet<EventHandler> m_invoke = new HashSet<EventHandler>();

        public EventSet() : this(new HashSet<EventHandler>())
        {
        }

        public EventSet(HashSet<EventHandler> collection) : base(collection)
        {
        }

        protected override void OnInvoke()
        {
            foreach (EventHandler handler in Collection)
            {
                m_invoke.Add(handler);
            }

            foreach (EventHandler handler in m_invoke)
            {
                handler.Invoke();
            }

            m_invoke.Clear();
        }
    }
}
